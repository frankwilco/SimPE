/***************************************************************************
 *   Original (C) Bidou, assumed to be licenced as part of SimPE           *
 *   Pet updates copyright (C) 2007 by Peter L Jones                       *
 *   pljones@users.sf.net                                                  *
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
using System.Data;
using SimPe;
using SimPe.Data;
using SimPe.Interfaces;
using SimPe.PackedFiles.Wrapper;


namespace SimPe.Plugin
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class CareerEditor : System.Windows.Forms.Form
	{
		#region Windows Form Designer generated code

		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TextBox CareerTitle;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown CareerLvls;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox JobTitleMale;
		private System.Windows.Forms.TextBox JobDescMale;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox Vehicle;
		private System.Windows.Forms.ComboBox Outfit;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox Language;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox JobTitleFemale;
		private System.Windows.Forms.TextBox JobDescFemale;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.CheckBox WorkSaturday;
		private System.Windows.Forms.CheckBox WorkFriday;
		private System.Windows.Forms.CheckBox WorkThursday;
		private System.Windows.Forms.CheckBox WorkWednesday;
		private System.Windows.Forms.CheckBox WorkTuesday;
		private System.Windows.Forms.CheckBox WorkMonday;
		private System.Windows.Forms.CheckBox WorkSunday;
		private System.Windows.Forms.NumericUpDown WorkWages;
		private System.Windows.Forms.NumericUpDown WorkFinishHour;
		private System.Windows.Forms.NumericUpDown WorkHoursWorked;
		private System.Windows.Forms.NumericUpDown WorkStartHour;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.NumericUpDown ComfortHours;
		private System.Windows.Forms.NumericUpDown HygieneTotal;
		private System.Windows.Forms.NumericUpDown BladderTotal;
		private System.Windows.Forms.NumericUpDown WorkBladder;
		private System.Windows.Forms.NumericUpDown WorkComfort;
		private System.Windows.Forms.NumericUpDown HungerHours;
		private System.Windows.Forms.NumericUpDown EnergyHours;
		private System.Windows.Forms.NumericUpDown WorkPublic;
		private System.Windows.Forms.NumericUpDown WorkHunger;
		private System.Windows.Forms.NumericUpDown EnvironmentTotal;
		private System.Windows.Forms.NumericUpDown BladderHours;
		private System.Windows.Forms.NumericUpDown ComfortTotal;
		private System.Windows.Forms.NumericUpDown HungerTotal;
		private System.Windows.Forms.NumericUpDown HygieneHours;
		private System.Windows.Forms.NumericUpDown ThirstHours;
		private System.Windows.Forms.NumericUpDown WorkEnergy;
		private System.Windows.Forms.NumericUpDown WorkFun;
		private System.Windows.Forms.NumericUpDown WorkThirst;
		private System.Windows.Forms.NumericUpDown WorkFamily;
		private System.Windows.Forms.NumericUpDown PublicHours;
		private System.Windows.Forms.NumericUpDown FamilyTotal;
		private System.Windows.Forms.NumericUpDown EnergyTotal;
		private System.Windows.Forms.NumericUpDown FunTotal;
		private System.Windows.Forms.NumericUpDown PublicTotal;
		private System.Windows.Forms.NumericUpDown FunHours;
		private System.Windows.Forms.NumericUpDown WorkHygiene;
		private System.Windows.Forms.NumericUpDown FamilyHours;
		private System.Windows.Forms.NumericUpDown EnvironmentHours;
		private System.Windows.Forms.NumericUpDown ThirstTotal;
		private System.Windows.Forms.NumericUpDown WorkEnvironment;
		private System.Windows.Forms.NumericUpDown PromoBody;
		private System.Windows.Forms.NumericUpDown PromoMechanical;
		private System.Windows.Forms.NumericUpDown PromoCooking;
		private System.Windows.Forms.NumericUpDown PromoCharisma;
		private System.Windows.Forms.NumericUpDown PromoFriends;
		private System.Windows.Forms.NumericUpDown PromoCleaning;
		private System.Windows.Forms.NumericUpDown PromoLogic;
		private System.Windows.Forms.NumericUpDown PromoCreativity;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.NumericUpDown ChancePercent;
		private System.Windows.Forms.TextBox ChoiceA;
		private System.Windows.Forms.TextBox ChoiceB;
		private System.Windows.Forms.TabControl tabControl2;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.TabPage tabPage7;
		private System.Windows.Forms.TabPage tabPage8;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.Label label44;
		private System.Windows.Forms.Label label45;
		private System.Windows.Forms.Label label46;
		private System.Windows.Forms.Label label47;
		private System.Windows.Forms.Label label48;
		private System.Windows.Forms.Label label49;
		private System.Windows.Forms.Label label50;
		private System.Windows.Forms.Label label51;
		private System.Windows.Forms.Label label52;
		private System.Windows.Forms.Label label62;
		private System.Windows.Forms.Label label63;
		private System.Windows.Forms.Label label64;
		private System.Windows.Forms.Label label65;
		private System.Windows.Forms.NumericUpDown ChanceCurrentLevel;
		private System.Windows.Forms.NumericUpDown ChoiceACleaning;
		private System.Windows.Forms.NumericUpDown ChoiceALogic;
		private System.Windows.Forms.NumericUpDown ChoiceACreativity;
		private System.Windows.Forms.NumericUpDown ChoiceABody;
		private System.Windows.Forms.NumericUpDown ChoiceACharisma;
		private System.Windows.Forms.NumericUpDown ChoiceAMechanical;
		private System.Windows.Forms.NumericUpDown ChoiceACooking;
		private System.Windows.Forms.TextBox ChanceTextFemale;
		private System.Windows.Forms.TextBox ChanceTextMale;
		private System.Windows.Forms.NumericUpDown ChoiceBCleaning;
		private System.Windows.Forms.NumericUpDown ChoiceBLogic;
		private System.Windows.Forms.NumericUpDown ChoiceBCreativity;
		private System.Windows.Forms.NumericUpDown ChoiceBBody;
		private System.Windows.Forms.NumericUpDown ChoiceBCharisma;
		private System.Windows.Forms.NumericUpDown ChoiceBMechanical;
		private System.Windows.Forms.NumericUpDown ChoiceBCooking;
		private System.Windows.Forms.TextBox PassAFemaleText;
		private System.Windows.Forms.TextBox PassAMaleText;
		private System.Windows.Forms.NumericUpDown PassAMoney;
		private System.Windows.Forms.NumericUpDown PassACleaning;
		private System.Windows.Forms.NumericUpDown PassALogic;
		private System.Windows.Forms.NumericUpDown PassACreativity;
		private System.Windows.Forms.NumericUpDown PassABody;
		private System.Windows.Forms.NumericUpDown PassACharisma;
		private System.Windows.Forms.NumericUpDown PassAMechanical;
		private System.Windows.Forms.NumericUpDown PassACooking;
		private System.Windows.Forms.NumericUpDown PassAJobLevel;
		private System.Windows.Forms.TextBox FailAFemaleText;
		private System.Windows.Forms.TextBox FailAMaleText;
		private System.Windows.Forms.Label label66;
		private System.Windows.Forms.Label label67;
		private System.Windows.Forms.Label label68;
		private System.Windows.Forms.Label label69;
		private System.Windows.Forms.Label label70;
		private System.Windows.Forms.NumericUpDown FailAMoney;
		private System.Windows.Forms.Label label71;
		private System.Windows.Forms.Label label72;
		private System.Windows.Forms.Label label73;
		private System.Windows.Forms.Label label74;
		private System.Windows.Forms.Label label75;
		private System.Windows.Forms.Label label76;
		private System.Windows.Forms.Label label77;
		private System.Windows.Forms.NumericUpDown FailACleaning;
		private System.Windows.Forms.NumericUpDown FailALogic;
		private System.Windows.Forms.NumericUpDown FailACreativity;
		private System.Windows.Forms.NumericUpDown FailABody;
		private System.Windows.Forms.NumericUpDown FailACharisma;
		private System.Windows.Forms.NumericUpDown FailAMechanical;
		private System.Windows.Forms.NumericUpDown FailACooking;
		private System.Windows.Forms.Label label78;
		private System.Windows.Forms.Label label79;
		private System.Windows.Forms.Label label80;
		private System.Windows.Forms.Label label90;
		private System.Windows.Forms.Label label91;
		private System.Windows.Forms.Label label92;
		private System.Windows.Forms.NumericUpDown FailAJobLevel;
		private System.Windows.Forms.TextBox PassBFemaleText;
		private System.Windows.Forms.TextBox PassBMaleText;
		private System.Windows.Forms.NumericUpDown PassBJobLevel;
		private System.Windows.Forms.NumericUpDown PassBMoney;
		private System.Windows.Forms.NumericUpDown PassBCleaning;
		private System.Windows.Forms.NumericUpDown PassBLogic;
		private System.Windows.Forms.NumericUpDown PassBCreativity;
		private System.Windows.Forms.NumericUpDown PassBBody;
		private System.Windows.Forms.NumericUpDown PassBCharisma;
		private System.Windows.Forms.NumericUpDown PassBMechanical;
		private System.Windows.Forms.NumericUpDown PassBCooking;
		private System.Windows.Forms.TextBox FailBFemaleText;
		private System.Windows.Forms.TextBox FailBMaleText;
		private System.Windows.Forms.NumericUpDown FailBJobLevel;
		private System.Windows.Forms.NumericUpDown FailBMoney;
		private System.Windows.Forms.NumericUpDown FailBCleaning;
		private System.Windows.Forms.NumericUpDown FailBLogic;
		private System.Windows.Forms.NumericUpDown FailBCreativity;
		private System.Windows.Forms.NumericUpDown FailBBody;
		private System.Windows.Forms.NumericUpDown FailBCharisma;
		private System.Windows.Forms.NumericUpDown FailBMechanical;
		private System.Windows.Forms.NumericUpDown FailBCooking;
		private System.Windows.Forms.Label label102;
		private System.Windows.Forms.ComboBox CareerReward;
		private System.Windows.Forms.ListView JobDetailList;
		private System.Windows.Forms.ColumnHeader JdLvl;
		private System.Windows.Forms.ColumnHeader JdJobTitle;
		private System.Windows.Forms.ColumnHeader JdDesc;
		private System.Windows.Forms.ColumnHeader JdOutfit;
		private System.Windows.Forms.ColumnHeader JdVehicle;
		private System.Windows.Forms.ListView HoursWagesList;
		private System.Windows.Forms.ColumnHeader HwLvl;
		private System.Windows.Forms.ColumnHeader HwStart;
		private System.Windows.Forms.ColumnHeader HwHours;
		private System.Windows.Forms.ColumnHeader HwEnd;
		private System.Windows.Forms.ColumnHeader HwWages;
        private ColumnHeader HwCatWages;
        private ColumnHeader HwDogWages;
        private System.Windows.Forms.ColumnHeader HwSun;
		private System.Windows.Forms.ColumnHeader HwMon;
		private System.Windows.Forms.ColumnHeader HwTue;
		private System.Windows.Forms.ColumnHeader HwWed;
		private System.Windows.Forms.ColumnHeader HwThu;
		private System.Windows.Forms.ColumnHeader HwFri;
		private System.Windows.Forms.ColumnHeader HwSat;
		private System.Windows.Forms.ListView PromoList;
		private System.Windows.Forms.ColumnHeader PrLvl;
		private System.Windows.Forms.ColumnHeader PrCooking;
		private System.Windows.Forms.ColumnHeader PrMechanical;
		private System.Windows.Forms.ColumnHeader PrCharisma;
		private System.Windows.Forms.ColumnHeader PrBody;
		private System.Windows.Forms.ColumnHeader PrCreativity;
		private System.Windows.Forms.ColumnHeader PrLogic;
		private System.Windows.Forms.ColumnHeader PrCleaning;
		private System.Windows.Forms.ColumnHeader PrFriends;
		private System.Windows.Forms.GroupBox PromoBox;
		private System.Windows.Forms.GroupBox HoursWagesBox;
		private System.Windows.Forms.GroupBox JobDetailsBox;
		private System.Windows.Forms.LinkLabel JobDetailsCopy;
		private System.Windows.Forms.LinkLabel ChanceCopy;
		private System.Windows.Forms.LinkLabel PassACopy;
		private System.Windows.Forms.LinkLabel FailACopy;
		private System.Windows.Forms.LinkLabel PassBCopy;
		private System.Windows.Forms.LinkLabel FailBCopy;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label53;
		private System.Windows.Forms.Label label54;
		private System.Windows.Forms.Label label55;
		private System.Windows.Forms.Label label56;
		private System.Windows.Forms.Label label57;
		private System.Windows.Forms.Label label58;
		private System.Windows.Forms.Label label59;
		private System.Windows.Forms.Label label60;
		private System.Windows.Forms.Label label61;
		private System.Windows.Forms.Label label81;
		private System.Windows.Forms.Label label82;
		private System.Windows.Forms.Label label83;
		private System.Windows.Forms.Label label84;
		private System.Windows.Forms.Label label85;
		private System.Windows.Forms.Label label86;
		private System.Windows.Forms.Label label87;
		private System.Windows.Forms.Label label88;
		private System.Windows.Forms.Label label89;
		private System.Windows.Forms.Label label93;
		private System.Windows.Forms.Label label94;
		private System.Windows.Forms.Label label95;
		private System.Windows.Forms.Label label96;
		private System.Windows.Forms.Label label97;
		private System.Windows.Forms.Label label98;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem5;
        private Label label99;
        private NumericUpDown nudWagesDog;
        private Label label100;
        private Label label101;
        private NumericUpDown nudPromoTricks;
        private NumericUpDown nudWagesCat;

        #endregion

        private IContainer components;

		private ushort femaleOffset, noLevels, currentLevel;
		
		private StrLanguage currentLanguage;

		private Str catalogueDesc;

		private Str jobTitles;
		private Str chanceCardsText;

		private Bhav BHavReward;

		private Bcon vehicleGUID;
		private Bcon outfitGUID;

		private Bcon startHour;
		private Bcon hoursWorked;
		private Bcon daysWorked;
        private Bcon wages;
        private Bcon wagesCat;
        private Bcon wagesDog;

		private Bcon[] skillReq;
		private Bcon friends;
        private Bcon tricks;

		private Bcon[] motiveDeltas;

		private Bcon tuning;

		private Bcon[] chanceASkills;
		private Bcon[] chanceAGood;
		private Bcon[] chanceABad;

		private Bcon[] chanceBSkills;
		private Bcon[] chanceBGood;
		private Bcon[] chanceBBad;

		private Bcon chanceChance;

		private Bcon lifeScore;
		private Bcon PTO;

		#region constants
		private const byte COOKING = 0;
		private const byte MECHANICAL = 1;
		private const byte BODY = 2;
		private const byte CHARISMA = 3;
		private const byte CREATIVITY = 4;
		private const byte LOGIC = 5;
		private const byte GARDENING = 6;
		private const byte CLEANING = 7;

		private const byte MONEY = 8;
		private const byte JOB = 9;

		private const byte HUNGER = 0;
		private const byte THIRST = 1;
		private const byte COMFORT = 2;
		private const byte HYGIENE = 3;
		private const byte BLADDER = 4;
		private const byte ENERGY= 5;
		private const byte FUN = 6;
		private const byte PUBLIC = 7;
		private const byte FAMILY = 8;
		private const byte ENVIRONMENT = 9;
		private const byte MENTAL = 10;

		private const byte MONDAY = 0;
		private const byte TUESDAY = 1;
		private const byte WEDNESDAY = 2;
		private const byte THURSDAY = 3;
		private const byte FRIDAY = 4;
		private const byte SATURDAY = 5;
		private const byte SUNDAY = 6;

		private string[] languageStringsMaster = new string[]
			{
					"0x00 - None",
				"0x01 - English (US)","0x02 - English (Int)","0x03 - French","0x04 - German","0x05 - Italian",
				"0x06 - Spanish","0x07 - Dutch","0x08 - Danish","0x09 - Swedish","0x0A - Norwegian",
				"0x0B - Finish","0x0C - Hebrew","0x0D - Russian","0x0E - Portuguese","0x0F - Japanese",
				"0x10 - Polish","0x11 - SimplifiedChinese","0x12 - TraditionalChinese","0x13 - Thai","0x14 - Korean",
				"0x15 - 21","0x16 - 22","0x17 - 23","0x18 - 24","0x19 - 25",
				"0x1A - 26",
				"0x1B - 27","0x1C - 28","0x1D - 29","0x1E - 30","0x1F - 31","0x20 - 32","0x21 - 33","0x22 - 34",
				"0x23 - Portuguese (Brazil)","0x24 - 36","0x25 - 37","0x26 - 38","0x27 - 39","0x28 - 40",
				"0x29 - 41","0x2A - 42","0x2B - 43","0x2C - 44" };

		private string[] outfitStrings = new string[]
				{
						"None","Astronaut","BlueScrubs","Burglar","CaptHero","CheapSuit","Chef",
					"Clerk","Coach","Cop","EMT","FastFood","Fatigues","GasStation","GreenScrubs",
					"HighRank","LabCoat1","LabCoat2","LeatherJacket","LowRank","MadLab","Mascot",
					"MastEvil","Mayor","MidRank","PowerSuit","Restaurant","Scrubs","SecurityGuard",
					"SlickSuit","SuperChef","Swat","Sweatsuit","Tracksuit","TweedJacket",
		
					"Electrocution", "Maternity", "NPC - Ambulance Driver (Paramedic)","NPC - Bartender",
					"NPC_Burglar", "NPC - BusDriver","NPC Clerk Outfit","NPC Cop","NPC DeliveryPerson",
					"NPC Exterminator","NPC FireFighter","New Gardener Outfit","NPC HandyPerson",
					"NPC HeadMaster","NPC Maid","NPC Mail Outfit","NPC Nanny","NPC PaperDelivery",
					"NPC Pizza Outfit","NPC Repo Outfit","NPC Salesperson","NPC SocialWorker",
					"PrivateSchool","Reaper Lei","Reaper NoLei","SkeletonGlow","SocialBunny Blue",
					"SocialBunny Pink","SocialBunny Yellow","Wedding Outfit",

					"MaternityShirtPants","BodyShirtUntuckedOxford","Outfit - Template",
					
					"Unknown"};

		private uint[] outfitGuids = new uint[]
				{
					0, 0x0CC8FB0A, 0x6CF36A28, 0xACCFBA59, 0x4CC8D355,
					0x6CC1394A, 0x6CDB4D89, 0xACCFB5BA, 0x6CE5E896, 0x2DC106EF,
					0x8CC8D510, 0xACCFB61B, 0xCCC8FA1E, 0x0CCFB4F4, 0x4CF368BE,
					0x8CCFA3D8, 0x8CCFA130, 0x8CCFA223, 0xCCE5E90F, 0x8CCFA318,
					0x2CD4EE5D, 0x8CE5EA26, 0xCCCF9FA7, 0xECE5EB2F, 0x8CCFA387,
					0x6CC13C27, 0xACD4EEE6, 0xACC8EE11, 0x6CC8CFBD, 0x0DCC7C4D,
					0xACCFB97C, 0xACE5EB8C, 0x0CCFA643, 0xECCFA694, 0xECCFB386,

					0xEDED8493, 0x6DD1D04B, 0xECA45D6D, 0x2CA45AE2, 0x0DB8AE38,
					0x8CC13127, 0x2CD89D6B, 0x2DC0FCD7, 0x8DC3893C, 0x0CA45C86,
					0xCDC38723, 0x8CDA36DA, 0xCD65FD9F, 0x6CC13409, 0x6DC38A6C,
					0xECD0F3FC, 0xCCD0F227, 0x6CC1322B, 0xACD0F47C, 0x6CD0F537,
					0x0CA45C32, 0x6CC130A6, 0xECD7C130, 0xCE029001, 0x2E02903A,
					0x6CD4EDE8, 0xEE028B7C, 0x2E028C23, 0xAE028CB9, 0x6D771A13,

					0x4CBC4BB4, 0x8CBC0B19, 0x0C91A937	};

		private uint[] vehicleGuids = new uint[]
				{
					0xAD0AB49C, 0x0D099B93, 0xAC43E058, 0x4CA1487C, 0x6C6CDEC6,
					0xCC69FDA3, 0xEC860630, 0x0CA42373, 0x8C5A4D9E, 0x4D50E553,
					0x4C03451A, 0x6CA4110A, 0x4C413B80, 0x0C85AE14, 0xCD08624E,
					0x4D09B954 };
		private string[] vehicleStrings = new string[]
				{
					"Captain Hero Flyaway","Helicopter - Executive","Helicopter - Army","Town Car",
					"Sports Car - Super","Sports Car - Mid","Sports Car - Low","Sports Team Bus",
					"Sedan","Taxi","Minivan","Limo","HMV","Hatchback","Police","Ambulance",
					"Unknown" };
		private uint[] rewardGuids = new uint[]
				{
					0x0C6E194A,0x8C4D2997,0xD1CD15C8,0xCC58DF85,0x6C2979FB,
					0xCC16D816,0x4C2148B0,0xCC20426A,0x6C6CE31F,0xAC314A3A};
		private string[] rewardStrings = new string[]
			{
				"Biotech Station","Candy Factory","Fingerprint Scanner","Hydroponic Garden","Obstacle Course",
				"Polygraph","Punching Bag","Putting Green","Surgical Dummy","Teleprompter",
				"Unknown" };
		private uint[] adultGuids = new uint[]
			{
				0x2C89E95F, 0x45196555, 0x6C9EBD0E, 0xEC9EBD5F, 0xAC9EBCE3,
				0x0C7761FD, 0x6C9EBD32, 0x2C945B14, 0x0C9EBD47, 0xEC77620B };
		private string[] adultStrings = new string[]
			{
				"Athletic","Business","Criminal","Culinary","Law Enforcement",
				"Medicine","Military","Politics","Science","Slacker",
				"Other..."};
		#endregion

		private ArrayList languageString, languageID;
		private SimPe.Packages.GeneratableFile package;
		private uint groupId;
		private bool hasReward, levelChanging;


		private bool oneEnglish, englishOnly;
        private ColumnHeader PrTricks;

		public CareerEditor()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			XmlRegistryKey rk = Helper.WindowsRegistry.PluginRegistryKey.CreateSubKey("CareerEditor");

			oneEnglish = (rk.GetValue("oneEnglish", "True").ToString()) == "True";
			englishOnly = (rk.GetValue("englishOnly", "False").ToString()) == "True";
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ChanceCopy = new System.Windows.Forms.LinkLabel();
            this.label65 = new System.Windows.Forms.Label();
            this.ChanceCurrentLevel = new System.Windows.Forms.NumericUpDown();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.PassACopy = new System.Windows.Forms.LinkLabel();
            this.PassAFemaleText = new System.Windows.Forms.TextBox();
            this.PassAMaleText = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.PassAJobLevel = new System.Windows.Forms.NumericUpDown();
            this.PassAMoney = new System.Windows.Forms.NumericUpDown();
            this.PassACleaning = new System.Windows.Forms.NumericUpDown();
            this.PassALogic = new System.Windows.Forms.NumericUpDown();
            this.PassACreativity = new System.Windows.Forms.NumericUpDown();
            this.PassABody = new System.Windows.Forms.NumericUpDown();
            this.PassACharisma = new System.Windows.Forms.NumericUpDown();
            this.PassAMechanical = new System.Windows.Forms.NumericUpDown();
            this.PassACooking = new System.Windows.Forms.NumericUpDown();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.FailACopy = new System.Windows.Forms.LinkLabel();
            this.FailAFemaleText = new System.Windows.Forms.TextBox();
            this.FailAMaleText = new System.Windows.Forms.TextBox();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.FailAJobLevel = new System.Windows.Forms.NumericUpDown();
            this.FailAMoney = new System.Windows.Forms.NumericUpDown();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.FailACleaning = new System.Windows.Forms.NumericUpDown();
            this.FailALogic = new System.Windows.Forms.NumericUpDown();
            this.FailACreativity = new System.Windows.Forms.NumericUpDown();
            this.FailABody = new System.Windows.Forms.NumericUpDown();
            this.FailACharisma = new System.Windows.Forms.NumericUpDown();
            this.FailAMechanical = new System.Windows.Forms.NumericUpDown();
            this.FailACooking = new System.Windows.Forms.NumericUpDown();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.PassBCopy = new System.Windows.Forms.LinkLabel();
            this.PassBFemaleText = new System.Windows.Forms.TextBox();
            this.PassBMaleText = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.PassBJobLevel = new System.Windows.Forms.NumericUpDown();
            this.PassBMoney = new System.Windows.Forms.NumericUpDown();
            this.PassBCleaning = new System.Windows.Forms.NumericUpDown();
            this.PassBLogic = new System.Windows.Forms.NumericUpDown();
            this.PassBCreativity = new System.Windows.Forms.NumericUpDown();
            this.PassBBody = new System.Windows.Forms.NumericUpDown();
            this.PassBCharisma = new System.Windows.Forms.NumericUpDown();
            this.PassBMechanical = new System.Windows.Forms.NumericUpDown();
            this.PassBCooking = new System.Windows.Forms.NumericUpDown();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.FailBCopy = new System.Windows.Forms.LinkLabel();
            this.FailBFemaleText = new System.Windows.Forms.TextBox();
            this.FailBMaleText = new System.Windows.Forms.TextBox();
            this.label90 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.FailBJobLevel = new System.Windows.Forms.NumericUpDown();
            this.FailBMoney = new System.Windows.Forms.NumericUpDown();
            this.FailBCleaning = new System.Windows.Forms.NumericUpDown();
            this.FailBLogic = new System.Windows.Forms.NumericUpDown();
            this.FailBCreativity = new System.Windows.Forms.NumericUpDown();
            this.FailBBody = new System.Windows.Forms.NumericUpDown();
            this.FailBCharisma = new System.Windows.Forms.NumericUpDown();
            this.FailBMechanical = new System.Windows.Forms.NumericUpDown();
            this.FailBCooking = new System.Windows.Forms.NumericUpDown();
            this.ChanceTextFemale = new System.Windows.Forms.TextBox();
            this.ChanceTextMale = new System.Windows.Forms.TextBox();
            this.ChoiceB = new System.Windows.Forms.TextBox();
            this.ChoiceA = new System.Windows.Forms.TextBox();
            this.ChoiceBCleaning = new System.Windows.Forms.NumericUpDown();
            this.ChoiceBLogic = new System.Windows.Forms.NumericUpDown();
            this.ChoiceBCreativity = new System.Windows.Forms.NumericUpDown();
            this.ChoiceBBody = new System.Windows.Forms.NumericUpDown();
            this.ChoiceBCharisma = new System.Windows.Forms.NumericUpDown();
            this.ChoiceBMechanical = new System.Windows.Forms.NumericUpDown();
            this.ChoiceBCooking = new System.Windows.Forms.NumericUpDown();
            this.ChoiceACleaning = new System.Windows.Forms.NumericUpDown();
            this.ChoiceALogic = new System.Windows.Forms.NumericUpDown();
            this.ChoiceACreativity = new System.Windows.Forms.NumericUpDown();
            this.ChoiceABody = new System.Windows.Forms.NumericUpDown();
            this.ChoiceACharisma = new System.Windows.Forms.NumericUpDown();
            this.ChoiceAMechanical = new System.Windows.Forms.NumericUpDown();
            this.ChoiceACooking = new System.Windows.Forms.NumericUpDown();
            this.ChancePercent = new System.Windows.Forms.NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.PromoBox = new System.Windows.Forms.GroupBox();
            this.label101 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.nudPromoTricks = new System.Windows.Forms.NumericUpDown();
            this.PromoFriends = new System.Windows.Forms.NumericUpDown();
            this.PromoCleaning = new System.Windows.Forms.NumericUpDown();
            this.PromoLogic = new System.Windows.Forms.NumericUpDown();
            this.PromoCreativity = new System.Windows.Forms.NumericUpDown();
            this.PromoCharisma = new System.Windows.Forms.NumericUpDown();
            this.PromoBody = new System.Windows.Forms.NumericUpDown();
            this.PromoMechanical = new System.Windows.Forms.NumericUpDown();
            this.PromoCooking = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.PromoList = new System.Windows.Forms.ListView();
            this.PrLvl = new System.Windows.Forms.ColumnHeader();
            this.PrCooking = new System.Windows.Forms.ColumnHeader();
            this.PrMechanical = new System.Windows.Forms.ColumnHeader();
            this.PrBody = new System.Windows.Forms.ColumnHeader();
            this.PrCharisma = new System.Windows.Forms.ColumnHeader();
            this.PrCreativity = new System.Windows.Forms.ColumnHeader();
            this.PrLogic = new System.Windows.Forms.ColumnHeader();
            this.PrCleaning = new System.Windows.Forms.ColumnHeader();
            this.PrFriends = new System.Windows.Forms.ColumnHeader();
            this.PrTricks = new System.Windows.Forms.ColumnHeader();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.HoursWagesBox = new System.Windows.Forms.GroupBox();
            this.WorkSaturday = new System.Windows.Forms.CheckBox();
            this.WorkFriday = new System.Windows.Forms.CheckBox();
            this.WorkThursday = new System.Windows.Forms.CheckBox();
            this.WorkWednesday = new System.Windows.Forms.CheckBox();
            this.WorkTuesday = new System.Windows.Forms.CheckBox();
            this.WorkMonday = new System.Windows.Forms.CheckBox();
            this.WorkSunday = new System.Windows.Forms.CheckBox();
            this.label100 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nudWagesCat = new System.Windows.Forms.NumericUpDown();
            this.nudWagesDog = new System.Windows.Forms.NumericUpDown();
            this.WorkWages = new System.Windows.Forms.NumericUpDown();
            this.WorkFinishHour = new System.Windows.Forms.NumericUpDown();
            this.WorkHoursWorked = new System.Windows.Forms.NumericUpDown();
            this.WorkStartHour = new System.Windows.Forms.NumericUpDown();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.ComfortHours = new System.Windows.Forms.NumericUpDown();
            this.HygieneTotal = new System.Windows.Forms.NumericUpDown();
            this.BladderTotal = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.WorkBladder = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.WorkComfort = new System.Windows.Forms.NumericUpDown();
            this.HungerHours = new System.Windows.Forms.NumericUpDown();
            this.EnergyHours = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.WorkPublic = new System.Windows.Forms.NumericUpDown();
            this.WorkHunger = new System.Windows.Forms.NumericUpDown();
            this.EnvironmentTotal = new System.Windows.Forms.NumericUpDown();
            this.BladderHours = new System.Windows.Forms.NumericUpDown();
            this.ComfortTotal = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.HungerTotal = new System.Windows.Forms.NumericUpDown();
            this.HygieneHours = new System.Windows.Forms.NumericUpDown();
            this.ThirstHours = new System.Windows.Forms.NumericUpDown();
            this.WorkEnergy = new System.Windows.Forms.NumericUpDown();
            this.WorkFun = new System.Windows.Forms.NumericUpDown();
            this.WorkThirst = new System.Windows.Forms.NumericUpDown();
            this.WorkFamily = new System.Windows.Forms.NumericUpDown();
            this.WorkEnvironment = new System.Windows.Forms.NumericUpDown();
            this.PublicHours = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.FamilyTotal = new System.Windows.Forms.NumericUpDown();
            this.EnergyTotal = new System.Windows.Forms.NumericUpDown();
            this.FunTotal = new System.Windows.Forms.NumericUpDown();
            this.PublicTotal = new System.Windows.Forms.NumericUpDown();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.FunHours = new System.Windows.Forms.NumericUpDown();
            this.WorkHygiene = new System.Windows.Forms.NumericUpDown();
            this.FamilyHours = new System.Windows.Forms.NumericUpDown();
            this.EnvironmentHours = new System.Windows.Forms.NumericUpDown();
            this.ThirstTotal = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.HoursWagesList = new System.Windows.Forms.ListView();
            this.HwLvl = new System.Windows.Forms.ColumnHeader();
            this.HwStart = new System.Windows.Forms.ColumnHeader();
            this.HwHours = new System.Windows.Forms.ColumnHeader();
            this.HwEnd = new System.Windows.Forms.ColumnHeader();
            this.HwWages = new System.Windows.Forms.ColumnHeader();
            this.HwDogWages = new System.Windows.Forms.ColumnHeader();
            this.HwCatWages = new System.Windows.Forms.ColumnHeader();
            this.HwSun = new System.Windows.Forms.ColumnHeader();
            this.HwMon = new System.Windows.Forms.ColumnHeader();
            this.HwTue = new System.Windows.Forms.ColumnHeader();
            this.HwWed = new System.Windows.Forms.ColumnHeader();
            this.HwThu = new System.Windows.Forms.ColumnHeader();
            this.HwFri = new System.Windows.Forms.ColumnHeader();
            this.HwSat = new System.Windows.Forms.ColumnHeader();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.JobDetailsBox = new System.Windows.Forms.GroupBox();
            this.JobDetailsCopy = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Vehicle = new System.Windows.Forms.ComboBox();
            this.Outfit = new System.Windows.Forms.ComboBox();
            this.JobDescFemale = new System.Windows.Forms.TextBox();
            this.JobTitleFemale = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.JobDescMale = new System.Windows.Forms.TextBox();
            this.JobTitleMale = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.JobDetailList = new System.Windows.Forms.ListView();
            this.JdLvl = new System.Windows.Forms.ColumnHeader();
            this.JdJobTitle = new System.Windows.Forms.ColumnHeader();
            this.JdDesc = new System.Windows.Forms.ColumnHeader();
            this.JdOutfit = new System.Windows.Forms.ColumnHeader();
            this.JdVehicle = new System.Windows.Forms.ColumnHeader();
            this.CareerLvls = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.CareerTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Language = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.CareerReward = new System.Windows.Forms.ComboBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChanceCurrentLevel)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassAJobLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassAMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassACleaning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassALogic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassACreativity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassABody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassACharisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassAMechanical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassACooking)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FailAJobLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailAMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailACleaning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailALogic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailACreativity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailABody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailACharisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailAMechanical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailACooking)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassBJobLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassBMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassBCleaning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassBLogic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassBCreativity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassBBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassBCharisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassBMechanical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassBCooking)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FailBJobLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailBMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailBCleaning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailBLogic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailBCreativity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailBBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailBCharisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailBMechanical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailBCooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceBCleaning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceBLogic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceBCreativity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceBBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceBCharisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceBMechanical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceBCooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceACleaning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceALogic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceACreativity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceABody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceACharisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceAMechanical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceACooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChancePercent)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.PromoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPromoTricks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromoFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromoCleaning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromoLogic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromoCreativity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromoCharisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromoBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromoMechanical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromoCooking)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.HoursWagesBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWagesCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWagesDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkWages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkFinishHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkHoursWorked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkStartHour)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComfortHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HygieneTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BladderTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkBladder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkComfort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HungerHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnergyHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkPublic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkHunger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnvironmentTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BladderHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComfortTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HungerTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HygieneHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirstHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkEnergy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkFun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkThirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkFamily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkEnvironment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PublicHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FamilyTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnergyTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PublicTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkHygiene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FamilyHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnvironmentHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirstTotal)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.JobDetailsBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CareerLvls)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ChanceCopy);
            this.tabPage4.Controls.Add(this.label65);
            this.tabPage4.Controls.Add(this.ChanceCurrentLevel);
            this.tabPage4.Controls.Add(this.label52);
            this.tabPage4.Controls.Add(this.label51);
            this.tabPage4.Controls.Add(this.label50);
            this.tabPage4.Controls.Add(this.label43);
            this.tabPage4.Controls.Add(this.label44);
            this.tabPage4.Controls.Add(this.label45);
            this.tabPage4.Controls.Add(this.label46);
            this.tabPage4.Controls.Add(this.label47);
            this.tabPage4.Controls.Add(this.label48);
            this.tabPage4.Controls.Add(this.label49);
            this.tabPage4.Controls.Add(this.label42);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.tabControl2);
            this.tabPage4.Controls.Add(this.ChanceTextFemale);
            this.tabPage4.Controls.Add(this.ChanceTextMale);
            this.tabPage4.Controls.Add(this.ChoiceB);
            this.tabPage4.Controls.Add(this.ChoiceA);
            this.tabPage4.Controls.Add(this.ChoiceBCleaning);
            this.tabPage4.Controls.Add(this.ChoiceBLogic);
            this.tabPage4.Controls.Add(this.ChoiceBCreativity);
            this.tabPage4.Controls.Add(this.ChoiceBBody);
            this.tabPage4.Controls.Add(this.ChoiceBCharisma);
            this.tabPage4.Controls.Add(this.ChoiceBMechanical);
            this.tabPage4.Controls.Add(this.ChoiceBCooking);
            this.tabPage4.Controls.Add(this.ChoiceACleaning);
            this.tabPage4.Controls.Add(this.ChoiceALogic);
            this.tabPage4.Controls.Add(this.ChoiceACreativity);
            this.tabPage4.Controls.Add(this.ChoiceABody);
            this.tabPage4.Controls.Add(this.ChoiceACharisma);
            this.tabPage4.Controls.Add(this.ChoiceAMechanical);
            this.tabPage4.Controls.Add(this.ChoiceACooking);
            this.tabPage4.Controls.Add(this.ChancePercent);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1176, 712);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Chance Cards";
            // 
            // ChanceCopy
            // 
            this.ChanceCopy.AutoSize = true;
            this.ChanceCopy.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChanceCopy.Location = new System.Drawing.Point(565, 321);
            this.ChanceCopy.Name = "ChanceCopy";
            this.ChanceCopy.Size = new System.Drawing.Size(72, 17);
            this.ChanceCopy.TabIndex = 90;
            this.ChanceCopy.TabStop = true;
            this.ChanceCopy.Text = "Copy ->";
            this.ChanceCopy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChanceCopy_LinkClicked);
            // 
            // label65
            // 
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(11, 10);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(106, 19);
            this.label65.TabIndex = 89;
            this.label65.Text = "Current Level";
            // 
            // ChanceCurrentLevel
            // 
            this.ChanceCurrentLevel.Location = new System.Drawing.Point(149, 10);
            this.ChanceCurrentLevel.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ChanceCurrentLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ChanceCurrentLevel.Name = "ChanceCurrentLevel";
            this.ChanceCurrentLevel.Size = new System.Drawing.Size(64, 24);
            this.ChanceCurrentLevel.TabIndex = 88;
            this.ChanceCurrentLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ChanceCurrentLevel.ValueChanged += new System.EventHandler(this.ChanceCurrentLevel_ValueChanged);
            // 
            // label52
            // 
            this.label52.Location = new System.Drawing.Point(597, 146);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(139, 19);
            this.label52.TabIndex = 87;
            this.label52.Text = "Text Female";
            // 
            // label51
            // 
            this.label51.Location = new System.Drawing.Point(21, 146);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(139, 19);
            this.label51.TabIndex = 86;
            this.label51.Text = "Text Male";
            // 
            // label50
            // 
            this.label50.Location = new System.Drawing.Point(480, 10);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(192, 19);
            this.label50.TabIndex = 85;
            this.label50.Text = "Chance of Happening %";
            // 
            // label43
            // 
            this.label43.Location = new System.Drawing.Point(725, 58);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(75, 20);
            this.label43.TabIndex = 84;
            this.label43.Text = "Cleaning";
            // 
            // label44
            // 
            this.label44.Location = new System.Drawing.Point(651, 58);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(53, 20);
            this.label44.TabIndex = 83;
            this.label44.Text = "Logic";
            // 
            // label45
            // 
            this.label45.Location = new System.Drawing.Point(555, 58);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(85, 20);
            this.label45.TabIndex = 82;
            this.label45.Text = "Creativity";
            // 
            // label46
            // 
            this.label46.Location = new System.Drawing.Point(384, 58);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(85, 20);
            this.label46.TabIndex = 81;
            this.label46.Text = "Charisma";
            // 
            // label47
            // 
            this.label47.Location = new System.Drawing.Point(480, 58);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(85, 20);
            this.label47.TabIndex = 80;
            this.label47.Text = "Body";
            // 
            // label48
            // 
            this.label48.Location = new System.Drawing.Point(288, 58);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(96, 20);
            this.label48.TabIndex = 79;
            this.label48.Text = "Mechanical";
            // 
            // label49
            // 
            this.label49.Location = new System.Drawing.Point(213, 58);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(75, 20);
            this.label49.TabIndex = 78;
            this.label49.Text = "Cooking";
            // 
            // label42
            // 
            this.label42.Location = new System.Drawing.Point(21, 117);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(75, 19);
            this.label42.TabIndex = 77;
            this.label42.Text = "ChoiceB";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(21, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 19);
            this.label12.TabIndex = 76;
            this.label12.Text = "ChoiceA";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Location = new System.Drawing.Point(21, 350);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1142, 349);
            this.tabControl2.TabIndex = 74;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Controls.Add(this.label53);
            this.tabPage5.Controls.Add(this.label54);
            this.tabPage5.Controls.Add(this.label55);
            this.tabPage5.Controls.Add(this.label56);
            this.tabPage5.Controls.Add(this.label57);
            this.tabPage5.Controls.Add(this.label58);
            this.tabPage5.Controls.Add(this.PassACopy);
            this.tabPage5.Controls.Add(this.PassAFemaleText);
            this.tabPage5.Controls.Add(this.PassAMaleText);
            this.tabPage5.Controls.Add(this.label63);
            this.tabPage5.Controls.Add(this.label64);
            this.tabPage5.Controls.Add(this.label62);
            this.tabPage5.Controls.Add(this.PassAJobLevel);
            this.tabPage5.Controls.Add(this.PassAMoney);
            this.tabPage5.Controls.Add(this.PassACleaning);
            this.tabPage5.Controls.Add(this.PassALogic);
            this.tabPage5.Controls.Add(this.PassACreativity);
            this.tabPage5.Controls.Add(this.PassABody);
            this.tabPage5.Controls.Add(this.PassACharisma);
            this.tabPage5.Controls.Add(this.PassAMechanical);
            this.tabPage5.Controls.Add(this.PassACooking);
            this.tabPage5.Location = new System.Drawing.Point(4, 26);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1134, 319);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Pass A";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(832, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 134;
            this.label2.Text = "Job Levels";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(704, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 19);
            this.label11.TabIndex = 133;
            this.label11.Text = "Money";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(619, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 19);
            this.label17.TabIndex = 132;
            this.label17.Text = "Cleaning";
            // 
            // label53
            // 
            this.label53.Location = new System.Drawing.Point(533, 10);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(54, 19);
            this.label53.TabIndex = 131;
            this.label53.Text = "Logic";
            // 
            // label54
            // 
            this.label54.Location = new System.Drawing.Point(437, 10);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(86, 19);
            this.label54.TabIndex = 130;
            this.label54.Text = "Creativity";
            // 
            // label55
            // 
            this.label55.Location = new System.Drawing.Point(277, 10);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(86, 19);
            this.label55.TabIndex = 129;
            this.label55.Text = "Charisma";
            // 
            // label56
            // 
            this.label56.Location = new System.Drawing.Point(363, 10);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(85, 19);
            this.label56.TabIndex = 128;
            this.label56.Text = "Body";
            // 
            // label57
            // 
            this.label57.Location = new System.Drawing.Point(181, 10);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(96, 19);
            this.label57.TabIndex = 127;
            this.label57.Text = "Mechanical";
            // 
            // label58
            // 
            this.label58.Location = new System.Drawing.Point(96, 10);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(75, 19);
            this.label58.TabIndex = 126;
            this.label58.Text = "Cooking";
            // 
            // PassACopy
            // 
            this.PassACopy.AutoSize = true;
            this.PassACopy.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassACopy.Location = new System.Drawing.Point(533, 291);
            this.PassACopy.Name = "PassACopy";
            this.PassACopy.Size = new System.Drawing.Size(72, 17);
            this.PassACopy.TabIndex = 108;
            this.PassACopy.TabStop = true;
            this.PassACopy.Text = "Copy ->";
            this.PassACopy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PassACopy_LinkClicked);
            // 
            // PassAFemaleText
            // 
            this.PassAFemaleText.Location = new System.Drawing.Point(576, 87);
            this.PassAFemaleText.Multiline = true;
            this.PassAFemaleText.Name = "PassAFemaleText";
            this.PassAFemaleText.Size = new System.Drawing.Size(555, 204);
            this.PassAFemaleText.TabIndex = 107;
            this.PassAFemaleText.Text = "textBox2";
            // 
            // PassAMaleText
            // 
            this.PassAMaleText.Location = new System.Drawing.Point(11, 87);
            this.PassAMaleText.Multiline = true;
            this.PassAMaleText.Name = "PassAMaleText";
            this.PassAMaleText.Size = new System.Drawing.Size(554, 204);
            this.PassAMaleText.TabIndex = 106;
            this.PassAMaleText.Text = "textBox1";
            // 
            // label63
            // 
            this.label63.Location = new System.Drawing.Point(576, 68);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(139, 19);
            this.label63.TabIndex = 105;
            this.label63.Text = "Text Female";
            // 
            // label64
            // 
            this.label64.Location = new System.Drawing.Point(11, 68);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(138, 19);
            this.label64.TabIndex = 104;
            this.label64.Text = "Text Male";
            // 
            // label62
            // 
            this.label62.Location = new System.Drawing.Point(11, 29);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(74, 20);
            this.label62.TabIndex = 103;
            this.label62.Text = "Effect";
            // 
            // PassAJobLevel
            // 
            this.PassAJobLevel.Location = new System.Drawing.Point(832, 29);
            this.PassAJobLevel.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.PassAJobLevel.Name = "PassAJobLevel";
            this.PassAJobLevel.Size = new System.Drawing.Size(64, 24);
            this.PassAJobLevel.TabIndex = 100;
            // 
            // PassAMoney
            // 
            this.PassAMoney.Location = new System.Drawing.Point(704, 29);
            this.PassAMoney.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.PassAMoney.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.PassAMoney.Name = "PassAMoney";
            this.PassAMoney.Size = new System.Drawing.Size(107, 24);
            this.PassAMoney.TabIndex = 99;
            // 
            // PassACleaning
            // 
            this.PassACleaning.Location = new System.Drawing.Point(619, 29);
            this.PassACleaning.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PassACleaning.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.PassACleaning.Name = "PassACleaning";
            this.PassACleaning.Size = new System.Drawing.Size(64, 24);
            this.PassACleaning.TabIndex = 91;
            // 
            // PassALogic
            // 
            this.PassALogic.Location = new System.Drawing.Point(533, 29);
            this.PassALogic.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PassALogic.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.PassALogic.Name = "PassALogic";
            this.PassALogic.Size = new System.Drawing.Size(64, 24);
            this.PassALogic.TabIndex = 90;
            // 
            // PassACreativity
            // 
            this.PassACreativity.Location = new System.Drawing.Point(448, 29);
            this.PassACreativity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PassACreativity.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.PassACreativity.Name = "PassACreativity";
            this.PassACreativity.Size = new System.Drawing.Size(64, 24);
            this.PassACreativity.TabIndex = 89;
            // 
            // PassABody
            // 
            this.PassABody.Location = new System.Drawing.Point(363, 29);
            this.PassABody.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PassABody.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.PassABody.Name = "PassABody";
            this.PassABody.Size = new System.Drawing.Size(64, 24);
            this.PassABody.TabIndex = 88;
            // 
            // PassACharisma
            // 
            this.PassACharisma.Location = new System.Drawing.Point(277, 29);
            this.PassACharisma.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PassACharisma.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.PassACharisma.Name = "PassACharisma";
            this.PassACharisma.Size = new System.Drawing.Size(64, 24);
            this.PassACharisma.TabIndex = 87;
            // 
            // PassAMechanical
            // 
            this.PassAMechanical.Location = new System.Drawing.Point(192, 29);
            this.PassAMechanical.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PassAMechanical.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.PassAMechanical.Name = "PassAMechanical";
            this.PassAMechanical.Size = new System.Drawing.Size(64, 24);
            this.PassAMechanical.TabIndex = 86;
            // 
            // PassACooking
            // 
            this.PassACooking.Location = new System.Drawing.Point(107, 29);
            this.PassACooking.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PassACooking.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.PassACooking.Name = "PassACooking";
            this.PassACooking.Size = new System.Drawing.Size(64, 24);
            this.PassACooking.TabIndex = 85;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.FailACopy);
            this.tabPage6.Controls.Add(this.FailAFemaleText);
            this.tabPage6.Controls.Add(this.FailAMaleText);
            this.tabPage6.Controls.Add(this.label66);
            this.tabPage6.Controls.Add(this.label67);
            this.tabPage6.Controls.Add(this.label68);
            this.tabPage6.Controls.Add(this.label69);
            this.tabPage6.Controls.Add(this.label70);
            this.tabPage6.Controls.Add(this.FailAJobLevel);
            this.tabPage6.Controls.Add(this.FailAMoney);
            this.tabPage6.Controls.Add(this.label71);
            this.tabPage6.Controls.Add(this.label72);
            this.tabPage6.Controls.Add(this.label73);
            this.tabPage6.Controls.Add(this.label74);
            this.tabPage6.Controls.Add(this.label75);
            this.tabPage6.Controls.Add(this.label76);
            this.tabPage6.Controls.Add(this.label77);
            this.tabPage6.Controls.Add(this.FailACleaning);
            this.tabPage6.Controls.Add(this.FailALogic);
            this.tabPage6.Controls.Add(this.FailACreativity);
            this.tabPage6.Controls.Add(this.FailABody);
            this.tabPage6.Controls.Add(this.FailACharisma);
            this.tabPage6.Controls.Add(this.FailAMechanical);
            this.tabPage6.Controls.Add(this.FailACooking);
            this.tabPage6.Location = new System.Drawing.Point(4, 26);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1134, 319);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Fail A";
            // 
            // FailACopy
            // 
            this.FailACopy.AutoSize = true;
            this.FailACopy.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FailACopy.Location = new System.Drawing.Point(544, 291);
            this.FailACopy.Name = "FailACopy";
            this.FailACopy.Size = new System.Drawing.Size(72, 17);
            this.FailACopy.TabIndex = 131;
            this.FailACopy.TabStop = true;
            this.FailACopy.Text = "Copy ->";
            this.FailACopy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FailACopy_LinkClicked);
            // 
            // FailAFemaleText
            // 
            this.FailAFemaleText.Location = new System.Drawing.Point(576, 87);
            this.FailAFemaleText.Multiline = true;
            this.FailAFemaleText.Name = "FailAFemaleText";
            this.FailAFemaleText.Size = new System.Drawing.Size(555, 204);
            this.FailAFemaleText.TabIndex = 130;
            this.FailAFemaleText.Text = "textBox2";
            // 
            // FailAMaleText
            // 
            this.FailAMaleText.Location = new System.Drawing.Point(11, 87);
            this.FailAMaleText.Multiline = true;
            this.FailAMaleText.Name = "FailAMaleText";
            this.FailAMaleText.Size = new System.Drawing.Size(554, 204);
            this.FailAMaleText.TabIndex = 129;
            this.FailAMaleText.Text = "textBox1";
            // 
            // label66
            // 
            this.label66.Location = new System.Drawing.Point(576, 68);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(139, 19);
            this.label66.TabIndex = 128;
            this.label66.Text = "Text Female";
            // 
            // label67
            // 
            this.label67.Location = new System.Drawing.Point(11, 68);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(138, 19);
            this.label67.TabIndex = 127;
            this.label67.Text = "Text Male";
            // 
            // label68
            // 
            this.label68.Location = new System.Drawing.Point(11, 29);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(74, 20);
            this.label68.TabIndex = 126;
            this.label68.Text = "Effect";
            // 
            // label69
            // 
            this.label69.Location = new System.Drawing.Point(832, 10);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(96, 19);
            this.label69.TabIndex = 125;
            this.label69.Text = "Job Levels";
            // 
            // label70
            // 
            this.label70.Location = new System.Drawing.Point(704, 10);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(64, 19);
            this.label70.TabIndex = 124;
            this.label70.Text = "Money";
            // 
            // FailAJobLevel
            // 
            this.FailAJobLevel.Location = new System.Drawing.Point(832, 29);
            this.FailAJobLevel.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.FailAJobLevel.Name = "FailAJobLevel";
            this.FailAJobLevel.Size = new System.Drawing.Size(64, 24);
            this.FailAJobLevel.TabIndex = 123;
            // 
            // FailAMoney
            // 
            this.FailAMoney.Location = new System.Drawing.Point(704, 29);
            this.FailAMoney.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.FailAMoney.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.FailAMoney.Name = "FailAMoney";
            this.FailAMoney.Size = new System.Drawing.Size(107, 24);
            this.FailAMoney.TabIndex = 122;
            // 
            // label71
            // 
            this.label71.Location = new System.Drawing.Point(619, 10);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(74, 19);
            this.label71.TabIndex = 121;
            this.label71.Text = "Cleaning";
            // 
            // label72
            // 
            this.label72.Location = new System.Drawing.Point(533, 10);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(54, 19);
            this.label72.TabIndex = 120;
            this.label72.Text = "Logic";
            // 
            // label73
            // 
            this.label73.Location = new System.Drawing.Point(437, 10);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(86, 19);
            this.label73.TabIndex = 119;
            this.label73.Text = "Creativity";
            // 
            // label74
            // 
            this.label74.Location = new System.Drawing.Point(277, 10);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(86, 19);
            this.label74.TabIndex = 118;
            this.label74.Text = "Charisma";
            // 
            // label75
            // 
            this.label75.Location = new System.Drawing.Point(363, 10);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(85, 19);
            this.label75.TabIndex = 117;
            this.label75.Text = "Body";
            // 
            // label76
            // 
            this.label76.Location = new System.Drawing.Point(181, 10);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(96, 19);
            this.label76.TabIndex = 116;
            this.label76.Text = "Mechanical";
            // 
            // label77
            // 
            this.label77.Location = new System.Drawing.Point(96, 10);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(75, 19);
            this.label77.TabIndex = 115;
            this.label77.Text = "Cooking";
            // 
            // FailACleaning
            // 
            this.FailACleaning.Location = new System.Drawing.Point(619, 29);
            this.FailACleaning.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FailACleaning.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.FailACleaning.Name = "FailACleaning";
            this.FailACleaning.Size = new System.Drawing.Size(64, 24);
            this.FailACleaning.TabIndex = 114;
            // 
            // FailALogic
            // 
            this.FailALogic.Location = new System.Drawing.Point(533, 29);
            this.FailALogic.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FailALogic.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.FailALogic.Name = "FailALogic";
            this.FailALogic.Size = new System.Drawing.Size(64, 24);
            this.FailALogic.TabIndex = 113;
            // 
            // FailACreativity
            // 
            this.FailACreativity.Location = new System.Drawing.Point(448, 29);
            this.FailACreativity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FailACreativity.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.FailACreativity.Name = "FailACreativity";
            this.FailACreativity.Size = new System.Drawing.Size(64, 24);
            this.FailACreativity.TabIndex = 112;
            // 
            // FailABody
            // 
            this.FailABody.Location = new System.Drawing.Point(363, 29);
            this.FailABody.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FailABody.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.FailABody.Name = "FailABody";
            this.FailABody.Size = new System.Drawing.Size(64, 24);
            this.FailABody.TabIndex = 111;
            // 
            // FailACharisma
            // 
            this.FailACharisma.Location = new System.Drawing.Point(277, 29);
            this.FailACharisma.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FailACharisma.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.FailACharisma.Name = "FailACharisma";
            this.FailACharisma.Size = new System.Drawing.Size(64, 24);
            this.FailACharisma.TabIndex = 110;
            // 
            // FailAMechanical
            // 
            this.FailAMechanical.Location = new System.Drawing.Point(192, 29);
            this.FailAMechanical.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FailAMechanical.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.FailAMechanical.Name = "FailAMechanical";
            this.FailAMechanical.Size = new System.Drawing.Size(64, 24);
            this.FailAMechanical.TabIndex = 109;
            // 
            // FailACooking
            // 
            this.FailACooking.Location = new System.Drawing.Point(107, 29);
            this.FailACooking.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FailACooking.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.FailACooking.Name = "FailACooking";
            this.FailACooking.Size = new System.Drawing.Size(64, 24);
            this.FailACooking.TabIndex = 108;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label59);
            this.tabPage7.Controls.Add(this.label60);
            this.tabPage7.Controls.Add(this.label61);
            this.tabPage7.Controls.Add(this.label81);
            this.tabPage7.Controls.Add(this.label82);
            this.tabPage7.Controls.Add(this.label83);
            this.tabPage7.Controls.Add(this.label84);
            this.tabPage7.Controls.Add(this.label85);
            this.tabPage7.Controls.Add(this.label86);
            this.tabPage7.Controls.Add(this.PassBCopy);
            this.tabPage7.Controls.Add(this.PassBFemaleText);
            this.tabPage7.Controls.Add(this.PassBMaleText);
            this.tabPage7.Controls.Add(this.label78);
            this.tabPage7.Controls.Add(this.label79);
            this.tabPage7.Controls.Add(this.label80);
            this.tabPage7.Controls.Add(this.PassBJobLevel);
            this.tabPage7.Controls.Add(this.PassBMoney);
            this.tabPage7.Controls.Add(this.PassBCleaning);
            this.tabPage7.Controls.Add(this.PassBLogic);
            this.tabPage7.Controls.Add(this.PassBCreativity);
            this.tabPage7.Controls.Add(this.PassBBody);
            this.tabPage7.Controls.Add(this.PassBCharisma);
            this.tabPage7.Controls.Add(this.PassBMechanical);
            this.tabPage7.Controls.Add(this.PassBCooking);
            this.tabPage7.Location = new System.Drawing.Point(4, 26);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1134, 319);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Pass B";
            // 
            // label59
            // 
            this.label59.Location = new System.Drawing.Point(832, 10);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(96, 19);
            this.label59.TabIndex = 140;
            this.label59.Text = "Job Levels";
            // 
            // label60
            // 
            this.label60.Location = new System.Drawing.Point(704, 10);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(64, 19);
            this.label60.TabIndex = 139;
            this.label60.Text = "Money";
            // 
            // label61
            // 
            this.label61.Location = new System.Drawing.Point(619, 10);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(74, 19);
            this.label61.TabIndex = 138;
            this.label61.Text = "Cleaning";
            // 
            // label81
            // 
            this.label81.Location = new System.Drawing.Point(533, 10);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(54, 19);
            this.label81.TabIndex = 137;
            this.label81.Text = "Logic";
            // 
            // label82
            // 
            this.label82.Location = new System.Drawing.Point(437, 10);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(86, 19);
            this.label82.TabIndex = 136;
            this.label82.Text = "Creativity";
            // 
            // label83
            // 
            this.label83.Location = new System.Drawing.Point(277, 10);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(86, 19);
            this.label83.TabIndex = 135;
            this.label83.Text = "Charisma";
            // 
            // label84
            // 
            this.label84.Location = new System.Drawing.Point(363, 10);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(85, 19);
            this.label84.TabIndex = 134;
            this.label84.Text = "Body";
            // 
            // label85
            // 
            this.label85.Location = new System.Drawing.Point(181, 10);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(96, 19);
            this.label85.TabIndex = 133;
            this.label85.Text = "Mechanical";
            // 
            // label86
            // 
            this.label86.Location = new System.Drawing.Point(96, 10);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(75, 19);
            this.label86.TabIndex = 132;
            this.label86.Text = "Cooking";
            // 
            // PassBCopy
            // 
            this.PassBCopy.AutoSize = true;
            this.PassBCopy.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassBCopy.Location = new System.Drawing.Point(544, 291);
            this.PassBCopy.Name = "PassBCopy";
            this.PassBCopy.Size = new System.Drawing.Size(72, 17);
            this.PassBCopy.TabIndex = 131;
            this.PassBCopy.TabStop = true;
            this.PassBCopy.Text = "Copy ->";
            this.PassBCopy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PassBCopy_LinkClicked);
            // 
            // PassBFemaleText
            // 
            this.PassBFemaleText.Location = new System.Drawing.Point(576, 87);
            this.PassBFemaleText.Multiline = true;
            this.PassBFemaleText.Name = "PassBFemaleText";
            this.PassBFemaleText.Size = new System.Drawing.Size(555, 204);
            this.PassBFemaleText.TabIndex = 130;
            this.PassBFemaleText.Text = "textBox2";
            // 
            // PassBMaleText
            // 
            this.PassBMaleText.Location = new System.Drawing.Point(11, 87);
            this.PassBMaleText.Multiline = true;
            this.PassBMaleText.Name = "PassBMaleText";
            this.PassBMaleText.Size = new System.Drawing.Size(554, 204);
            this.PassBMaleText.TabIndex = 129;
            this.PassBMaleText.Text = "textBox1";
            // 
            // label78
            // 
            this.label78.Location = new System.Drawing.Point(576, 68);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(139, 19);
            this.label78.TabIndex = 128;
            this.label78.Text = "Text Female";
            // 
            // label79
            // 
            this.label79.Location = new System.Drawing.Point(11, 68);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(138, 19);
            this.label79.TabIndex = 127;
            this.label79.Text = "Text Male";
            // 
            // label80
            // 
            this.label80.Location = new System.Drawing.Point(11, 29);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(74, 20);
            this.label80.TabIndex = 126;
            this.label80.Text = "Effect";
            // 
            // PassBJobLevel
            // 
            this.PassBJobLevel.Location = new System.Drawing.Point(832, 29);
            this.PassBJobLevel.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.PassBJobLevel.Name = "PassBJobLevel";
            this.PassBJobLevel.Size = new System.Drawing.Size(64, 24);
            this.PassBJobLevel.TabIndex = 123;
            // 
            // PassBMoney
            // 
            this.PassBMoney.Location = new System.Drawing.Point(704, 29);
            this.PassBMoney.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.PassBMoney.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.PassBMoney.Name = "PassBMoney";
            this.PassBMoney.Size = new System.Drawing.Size(107, 24);
            this.PassBMoney.TabIndex = 122;
            // 
            // PassBCleaning
            // 
            this.PassBCleaning.Location = new System.Drawing.Point(619, 29);
            this.PassBCleaning.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PassBCleaning.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.PassBCleaning.Name = "PassBCleaning";
            this.PassBCleaning.Size = new System.Drawing.Size(64, 24);
            this.PassBCleaning.TabIndex = 114;
            // 
            // PassBLogic
            // 
            this.PassBLogic.Location = new System.Drawing.Point(533, 29);
            this.PassBLogic.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PassBLogic.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.PassBLogic.Name = "PassBLogic";
            this.PassBLogic.Size = new System.Drawing.Size(64, 24);
            this.PassBLogic.TabIndex = 113;
            // 
            // PassBCreativity
            // 
            this.PassBCreativity.Location = new System.Drawing.Point(448, 29);
            this.PassBCreativity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PassBCreativity.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.PassBCreativity.Name = "PassBCreativity";
            this.PassBCreativity.Size = new System.Drawing.Size(64, 24);
            this.PassBCreativity.TabIndex = 112;
            // 
            // PassBBody
            // 
            this.PassBBody.Location = new System.Drawing.Point(363, 29);
            this.PassBBody.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PassBBody.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.PassBBody.Name = "PassBBody";
            this.PassBBody.Size = new System.Drawing.Size(64, 24);
            this.PassBBody.TabIndex = 111;
            // 
            // PassBCharisma
            // 
            this.PassBCharisma.Location = new System.Drawing.Point(277, 29);
            this.PassBCharisma.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PassBCharisma.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.PassBCharisma.Name = "PassBCharisma";
            this.PassBCharisma.Size = new System.Drawing.Size(64, 24);
            this.PassBCharisma.TabIndex = 110;
            // 
            // PassBMechanical
            // 
            this.PassBMechanical.Location = new System.Drawing.Point(192, 29);
            this.PassBMechanical.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PassBMechanical.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.PassBMechanical.Name = "PassBMechanical";
            this.PassBMechanical.Size = new System.Drawing.Size(64, 24);
            this.PassBMechanical.TabIndex = 109;
            // 
            // PassBCooking
            // 
            this.PassBCooking.Location = new System.Drawing.Point(107, 29);
            this.PassBCooking.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PassBCooking.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.PassBCooking.Name = "PassBCooking";
            this.PassBCooking.Size = new System.Drawing.Size(64, 24);
            this.PassBCooking.TabIndex = 108;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.label87);
            this.tabPage8.Controls.Add(this.label88);
            this.tabPage8.Controls.Add(this.label89);
            this.tabPage8.Controls.Add(this.label93);
            this.tabPage8.Controls.Add(this.label94);
            this.tabPage8.Controls.Add(this.label95);
            this.tabPage8.Controls.Add(this.label96);
            this.tabPage8.Controls.Add(this.label97);
            this.tabPage8.Controls.Add(this.label98);
            this.tabPage8.Controls.Add(this.FailBCopy);
            this.tabPage8.Controls.Add(this.FailBFemaleText);
            this.tabPage8.Controls.Add(this.FailBMaleText);
            this.tabPage8.Controls.Add(this.label90);
            this.tabPage8.Controls.Add(this.label91);
            this.tabPage8.Controls.Add(this.label92);
            this.tabPage8.Controls.Add(this.FailBJobLevel);
            this.tabPage8.Controls.Add(this.FailBMoney);
            this.tabPage8.Controls.Add(this.FailBCleaning);
            this.tabPage8.Controls.Add(this.FailBLogic);
            this.tabPage8.Controls.Add(this.FailBCreativity);
            this.tabPage8.Controls.Add(this.FailBBody);
            this.tabPage8.Controls.Add(this.FailBCharisma);
            this.tabPage8.Controls.Add(this.FailBMechanical);
            this.tabPage8.Controls.Add(this.FailBCooking);
            this.tabPage8.Location = new System.Drawing.Point(4, 26);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1134, 319);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "Fail B";
            // 
            // label87
            // 
            this.label87.Location = new System.Drawing.Point(832, 10);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(96, 19);
            this.label87.TabIndex = 140;
            this.label87.Text = "Job Levels";
            // 
            // label88
            // 
            this.label88.Location = new System.Drawing.Point(704, 10);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(64, 19);
            this.label88.TabIndex = 139;
            this.label88.Text = "Money";
            // 
            // label89
            // 
            this.label89.Location = new System.Drawing.Point(619, 10);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(74, 19);
            this.label89.TabIndex = 138;
            this.label89.Text = "Cleaning";
            // 
            // label93
            // 
            this.label93.Location = new System.Drawing.Point(533, 10);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(54, 19);
            this.label93.TabIndex = 137;
            this.label93.Text = "Logic";
            // 
            // label94
            // 
            this.label94.Location = new System.Drawing.Point(437, 10);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(86, 19);
            this.label94.TabIndex = 136;
            this.label94.Text = "Creativity";
            // 
            // label95
            // 
            this.label95.Location = new System.Drawing.Point(277, 10);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(86, 19);
            this.label95.TabIndex = 135;
            this.label95.Text = "Charisma";
            // 
            // label96
            // 
            this.label96.Location = new System.Drawing.Point(363, 10);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(85, 19);
            this.label96.TabIndex = 134;
            this.label96.Text = "Body";
            // 
            // label97
            // 
            this.label97.Location = new System.Drawing.Point(181, 10);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(96, 19);
            this.label97.TabIndex = 133;
            this.label97.Text = "Mechanical";
            // 
            // label98
            // 
            this.label98.Location = new System.Drawing.Point(96, 10);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(75, 19);
            this.label98.TabIndex = 132;
            this.label98.Text = "Cooking";
            // 
            // FailBCopy
            // 
            this.FailBCopy.AutoSize = true;
            this.FailBCopy.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FailBCopy.Location = new System.Drawing.Point(533, 291);
            this.FailBCopy.Name = "FailBCopy";
            this.FailBCopy.Size = new System.Drawing.Size(72, 17);
            this.FailBCopy.TabIndex = 131;
            this.FailBCopy.TabStop = true;
            this.FailBCopy.Text = "Copy ->";
            this.FailBCopy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FailBCopy_LinkClicked);
            // 
            // FailBFemaleText
            // 
            this.FailBFemaleText.Location = new System.Drawing.Point(576, 87);
            this.FailBFemaleText.Multiline = true;
            this.FailBFemaleText.Name = "FailBFemaleText";
            this.FailBFemaleText.Size = new System.Drawing.Size(555, 204);
            this.FailBFemaleText.TabIndex = 130;
            this.FailBFemaleText.Text = "textBox2";
            // 
            // FailBMaleText
            // 
            this.FailBMaleText.Location = new System.Drawing.Point(11, 87);
            this.FailBMaleText.Multiline = true;
            this.FailBMaleText.Name = "FailBMaleText";
            this.FailBMaleText.Size = new System.Drawing.Size(554, 204);
            this.FailBMaleText.TabIndex = 129;
            this.FailBMaleText.Text = "textBox1";
            // 
            // label90
            // 
            this.label90.Location = new System.Drawing.Point(597, 68);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(139, 19);
            this.label90.TabIndex = 128;
            this.label90.Text = "Text Female";
            // 
            // label91
            // 
            this.label91.Location = new System.Drawing.Point(11, 68);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(138, 19);
            this.label91.TabIndex = 127;
            this.label91.Text = "Text Male";
            // 
            // label92
            // 
            this.label92.Location = new System.Drawing.Point(11, 29);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(74, 20);
            this.label92.TabIndex = 126;
            this.label92.Text = "Effect";
            // 
            // FailBJobLevel
            // 
            this.FailBJobLevel.Location = new System.Drawing.Point(832, 29);
            this.FailBJobLevel.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.FailBJobLevel.Name = "FailBJobLevel";
            this.FailBJobLevel.Size = new System.Drawing.Size(64, 24);
            this.FailBJobLevel.TabIndex = 123;
            // 
            // FailBMoney
            // 
            this.FailBMoney.Location = new System.Drawing.Point(704, 29);
            this.FailBMoney.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.FailBMoney.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.FailBMoney.Name = "FailBMoney";
            this.FailBMoney.Size = new System.Drawing.Size(107, 24);
            this.FailBMoney.TabIndex = 122;
            // 
            // FailBCleaning
            // 
            this.FailBCleaning.Location = new System.Drawing.Point(619, 29);
            this.FailBCleaning.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FailBCleaning.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.FailBCleaning.Name = "FailBCleaning";
            this.FailBCleaning.Size = new System.Drawing.Size(64, 24);
            this.FailBCleaning.TabIndex = 114;
            // 
            // FailBLogic
            // 
            this.FailBLogic.Location = new System.Drawing.Point(533, 29);
            this.FailBLogic.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FailBLogic.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.FailBLogic.Name = "FailBLogic";
            this.FailBLogic.Size = new System.Drawing.Size(64, 24);
            this.FailBLogic.TabIndex = 113;
            // 
            // FailBCreativity
            // 
            this.FailBCreativity.Location = new System.Drawing.Point(448, 29);
            this.FailBCreativity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FailBCreativity.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.FailBCreativity.Name = "FailBCreativity";
            this.FailBCreativity.Size = new System.Drawing.Size(64, 24);
            this.FailBCreativity.TabIndex = 112;
            // 
            // FailBBody
            // 
            this.FailBBody.Location = new System.Drawing.Point(363, 29);
            this.FailBBody.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FailBBody.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.FailBBody.Name = "FailBBody";
            this.FailBBody.Size = new System.Drawing.Size(64, 24);
            this.FailBBody.TabIndex = 111;
            // 
            // FailBCharisma
            // 
            this.FailBCharisma.Location = new System.Drawing.Point(277, 29);
            this.FailBCharisma.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FailBCharisma.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.FailBCharisma.Name = "FailBCharisma";
            this.FailBCharisma.Size = new System.Drawing.Size(64, 24);
            this.FailBCharisma.TabIndex = 110;
            // 
            // FailBMechanical
            // 
            this.FailBMechanical.Location = new System.Drawing.Point(192, 29);
            this.FailBMechanical.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FailBMechanical.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.FailBMechanical.Name = "FailBMechanical";
            this.FailBMechanical.Size = new System.Drawing.Size(64, 24);
            this.FailBMechanical.TabIndex = 109;
            // 
            // FailBCooking
            // 
            this.FailBCooking.Location = new System.Drawing.Point(107, 29);
            this.FailBCooking.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FailBCooking.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.FailBCooking.Name = "FailBCooking";
            this.FailBCooking.Size = new System.Drawing.Size(64, 24);
            this.FailBCooking.TabIndex = 108;
            // 
            // ChanceTextFemale
            // 
            this.ChanceTextFemale.Location = new System.Drawing.Point(597, 165);
            this.ChanceTextFemale.Multiline = true;
            this.ChanceTextFemale.Name = "ChanceTextFemale";
            this.ChanceTextFemale.Size = new System.Drawing.Size(576, 156);
            this.ChanceTextFemale.TabIndex = 73;
            this.ChanceTextFemale.Text = "textBox4";
            // 
            // ChanceTextMale
            // 
            this.ChanceTextMale.Location = new System.Drawing.Point(21, 165);
            this.ChanceTextMale.Multiline = true;
            this.ChanceTextMale.Name = "ChanceTextMale";
            this.ChanceTextMale.Size = new System.Drawing.Size(576, 156);
            this.ChanceTextMale.TabIndex = 72;
            this.ChanceTextMale.Text = "textBox3";
            // 
            // ChoiceB
            // 
            this.ChoiceB.Location = new System.Drawing.Point(96, 117);
            this.ChoiceB.Name = "ChoiceB";
            this.ChoiceB.Size = new System.Drawing.Size(117, 24);
            this.ChoiceB.TabIndex = 53;
            this.ChoiceB.Text = "ChoiceB";
            // 
            // ChoiceA
            // 
            this.ChoiceA.Location = new System.Drawing.Point(96, 78);
            this.ChoiceA.Name = "ChoiceA";
            this.ChoiceA.Size = new System.Drawing.Size(117, 24);
            this.ChoiceA.TabIndex = 52;
            this.ChoiceA.Text = "ChoiceA";
            // 
            // ChoiceBCleaning
            // 
            this.ChoiceBCleaning.Location = new System.Drawing.Point(736, 117);
            this.ChoiceBCleaning.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ChoiceBCleaning.Name = "ChoiceBCleaning";
            this.ChoiceBCleaning.Size = new System.Drawing.Size(64, 24);
            this.ChoiceBCleaning.TabIndex = 32;
            // 
            // ChoiceBLogic
            // 
            this.ChoiceBLogic.Location = new System.Drawing.Point(651, 117);
            this.ChoiceBLogic.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ChoiceBLogic.Name = "ChoiceBLogic";
            this.ChoiceBLogic.Size = new System.Drawing.Size(64, 24);
            this.ChoiceBLogic.TabIndex = 31;
            // 
            // ChoiceBCreativity
            // 
            this.ChoiceBCreativity.Location = new System.Drawing.Point(565, 117);
            this.ChoiceBCreativity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ChoiceBCreativity.Name = "ChoiceBCreativity";
            this.ChoiceBCreativity.Size = new System.Drawing.Size(64, 24);
            this.ChoiceBCreativity.TabIndex = 30;
            // 
            // ChoiceBBody
            // 
            this.ChoiceBBody.Location = new System.Drawing.Point(480, 117);
            this.ChoiceBBody.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ChoiceBBody.Name = "ChoiceBBody";
            this.ChoiceBBody.Size = new System.Drawing.Size(64, 24);
            this.ChoiceBBody.TabIndex = 29;
            // 
            // ChoiceBCharisma
            // 
            this.ChoiceBCharisma.Location = new System.Drawing.Point(395, 117);
            this.ChoiceBCharisma.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ChoiceBCharisma.Name = "ChoiceBCharisma";
            this.ChoiceBCharisma.Size = new System.Drawing.Size(64, 24);
            this.ChoiceBCharisma.TabIndex = 28;
            // 
            // ChoiceBMechanical
            // 
            this.ChoiceBMechanical.Location = new System.Drawing.Point(309, 117);
            this.ChoiceBMechanical.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ChoiceBMechanical.Name = "ChoiceBMechanical";
            this.ChoiceBMechanical.Size = new System.Drawing.Size(64, 24);
            this.ChoiceBMechanical.TabIndex = 27;
            // 
            // ChoiceBCooking
            // 
            this.ChoiceBCooking.Location = new System.Drawing.Point(224, 117);
            this.ChoiceBCooking.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ChoiceBCooking.Name = "ChoiceBCooking";
            this.ChoiceBCooking.Size = new System.Drawing.Size(64, 24);
            this.ChoiceBCooking.TabIndex = 26;
            // 
            // ChoiceACleaning
            // 
            this.ChoiceACleaning.Location = new System.Drawing.Point(736, 78);
            this.ChoiceACleaning.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ChoiceACleaning.Name = "ChoiceACleaning";
            this.ChoiceACleaning.Size = new System.Drawing.Size(64, 24);
            this.ChoiceACleaning.TabIndex = 24;
            // 
            // ChoiceALogic
            // 
            this.ChoiceALogic.Location = new System.Drawing.Point(651, 78);
            this.ChoiceALogic.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ChoiceALogic.Name = "ChoiceALogic";
            this.ChoiceALogic.Size = new System.Drawing.Size(64, 24);
            this.ChoiceALogic.TabIndex = 23;
            // 
            // ChoiceACreativity
            // 
            this.ChoiceACreativity.Location = new System.Drawing.Point(565, 78);
            this.ChoiceACreativity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ChoiceACreativity.Name = "ChoiceACreativity";
            this.ChoiceACreativity.Size = new System.Drawing.Size(64, 24);
            this.ChoiceACreativity.TabIndex = 22;
            // 
            // ChoiceABody
            // 
            this.ChoiceABody.Location = new System.Drawing.Point(480, 78);
            this.ChoiceABody.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ChoiceABody.Name = "ChoiceABody";
            this.ChoiceABody.Size = new System.Drawing.Size(64, 24);
            this.ChoiceABody.TabIndex = 21;
            // 
            // ChoiceACharisma
            // 
            this.ChoiceACharisma.Location = new System.Drawing.Point(395, 78);
            this.ChoiceACharisma.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ChoiceACharisma.Name = "ChoiceACharisma";
            this.ChoiceACharisma.Size = new System.Drawing.Size(64, 24);
            this.ChoiceACharisma.TabIndex = 20;
            // 
            // ChoiceAMechanical
            // 
            this.ChoiceAMechanical.Location = new System.Drawing.Point(309, 78);
            this.ChoiceAMechanical.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ChoiceAMechanical.Name = "ChoiceAMechanical";
            this.ChoiceAMechanical.Size = new System.Drawing.Size(64, 24);
            this.ChoiceAMechanical.TabIndex = 19;
            // 
            // ChoiceACooking
            // 
            this.ChoiceACooking.Location = new System.Drawing.Point(224, 78);
            this.ChoiceACooking.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ChoiceACooking.Name = "ChoiceACooking";
            this.ChoiceACooking.Size = new System.Drawing.Size(64, 24);
            this.ChoiceACooking.TabIndex = 18;
            // 
            // ChancePercent
            // 
            this.ChancePercent.Location = new System.Drawing.Point(672, 10);
            this.ChancePercent.Name = "ChancePercent";
            this.ChancePercent.Size = new System.Drawing.Size(64, 24);
            this.ChancePercent.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.PromoBox);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1176, 712);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Promotion";
            // 
            // PromoBox
            // 
            this.PromoBox.Controls.Add(this.label101);
            this.PromoBox.Controls.Add(this.label41);
            this.PromoBox.Controls.Add(this.label40);
            this.PromoBox.Controls.Add(this.label39);
            this.PromoBox.Controls.Add(this.label38);
            this.PromoBox.Controls.Add(this.label37);
            this.PromoBox.Controls.Add(this.label36);
            this.PromoBox.Controls.Add(this.label35);
            this.PromoBox.Controls.Add(this.label34);
            this.PromoBox.Controls.Add(this.nudPromoTricks);
            this.PromoBox.Controls.Add(this.PromoFriends);
            this.PromoBox.Controls.Add(this.PromoCleaning);
            this.PromoBox.Controls.Add(this.PromoLogic);
            this.PromoBox.Controls.Add(this.PromoCreativity);
            this.PromoBox.Controls.Add(this.PromoCharisma);
            this.PromoBox.Controls.Add(this.PromoBody);
            this.PromoBox.Controls.Add(this.PromoMechanical);
            this.PromoBox.Controls.Add(this.PromoCooking);
            this.PromoBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PromoBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromoBox.Location = new System.Drawing.Point(11, 437);
            this.PromoBox.Name = "PromoBox";
            this.PromoBox.Size = new System.Drawing.Size(1152, 253);
            this.PromoBox.TabIndex = 20;
            this.PromoBox.TabStop = false;
            this.PromoBox.Text = "Current Level";
            // 
            // label101
            // 
            this.label101.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label101.Location = new System.Drawing.Point(207, 51);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(149, 20);
            this.label101.TabIndex = 25;
            this.label101.Text = "Needed Commands";
            // 
            // label41
            // 
            this.label41.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(207, 21);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(118, 20);
            this.label41.TabIndex = 25;
            this.label41.Text = "Family Friends";
            // 
            // label40
            // 
            this.label40.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(11, 194);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(85, 20);
            this.label40.TabIndex = 24;
            this.label40.Text = "Cleaning";
            // 
            // label39
            // 
            this.label39.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(11, 165);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(85, 20);
            this.label39.TabIndex = 23;
            this.label39.Text = "Logic";
            // 
            // label38
            // 
            this.label38.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(11, 136);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(85, 19);
            this.label38.TabIndex = 22;
            this.label38.Text = "Creativity";
            // 
            // label37
            // 
            this.label37.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(11, 109);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(85, 19);
            this.label37.TabIndex = 21;
            this.label37.Text = "Charisma";
            // 
            // label36
            // 
            this.label36.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(11, 79);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(85, 19);
            this.label36.TabIndex = 20;
            this.label36.Text = "Body";
            // 
            // label35
            // 
            this.label35.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(11, 49);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(96, 19);
            this.label35.TabIndex = 19;
            this.label35.Text = "Mechanical";
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(11, 19);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(85, 20);
            this.label34.TabIndex = 18;
            this.label34.Text = "Cooking";
            // 
            // nudPromoTricks
            // 
            this.nudPromoTricks.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPromoTricks.Location = new System.Drawing.Point(362, 49);
            this.nudPromoTricks.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudPromoTricks.Name = "nudPromoTricks";
            this.nudPromoTricks.Size = new System.Drawing.Size(64, 24);
            this.nudPromoTricks.TabIndex = 17;
            this.nudPromoTricks.ValueChanged += new System.EventHandler(this.Promo_ValueChanged);
            this.nudPromoTricks.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Promo_KeyUp);
            // 
            // PromoFriends
            // 
            this.PromoFriends.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromoFriends.Location = new System.Drawing.Point(362, 19);
            this.PromoFriends.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.PromoFriends.Name = "PromoFriends";
            this.PromoFriends.Size = new System.Drawing.Size(64, 24);
            this.PromoFriends.TabIndex = 17;
            this.PromoFriends.ValueChanged += new System.EventHandler(this.Promo_ValueChanged);
            this.PromoFriends.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Promo_KeyUp);
            // 
            // PromoCleaning
            // 
            this.PromoCleaning.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromoCleaning.Location = new System.Drawing.Point(117, 194);
            this.PromoCleaning.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PromoCleaning.Name = "PromoCleaning";
            this.PromoCleaning.Size = new System.Drawing.Size(64, 24);
            this.PromoCleaning.TabIndex = 16;
            this.PromoCleaning.ValueChanged += new System.EventHandler(this.Promo_ValueChanged);
            this.PromoCleaning.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Promo_KeyUp);
            // 
            // PromoLogic
            // 
            this.PromoLogic.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromoLogic.Location = new System.Drawing.Point(117, 165);
            this.PromoLogic.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PromoLogic.Name = "PromoLogic";
            this.PromoLogic.Size = new System.Drawing.Size(64, 24);
            this.PromoLogic.TabIndex = 15;
            this.PromoLogic.ValueChanged += new System.EventHandler(this.Promo_ValueChanged);
            this.PromoLogic.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Promo_KeyUp);
            // 
            // PromoCreativity
            // 
            this.PromoCreativity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromoCreativity.Location = new System.Drawing.Point(117, 136);
            this.PromoCreativity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PromoCreativity.Name = "PromoCreativity";
            this.PromoCreativity.Size = new System.Drawing.Size(64, 24);
            this.PromoCreativity.TabIndex = 14;
            this.PromoCreativity.ValueChanged += new System.EventHandler(this.Promo_ValueChanged);
            this.PromoCreativity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Promo_KeyUp);
            // 
            // PromoCharisma
            // 
            this.PromoCharisma.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromoCharisma.Location = new System.Drawing.Point(117, 109);
            this.PromoCharisma.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PromoCharisma.Name = "PromoCharisma";
            this.PromoCharisma.Size = new System.Drawing.Size(64, 24);
            this.PromoCharisma.TabIndex = 13;
            this.PromoCharisma.ValueChanged += new System.EventHandler(this.Promo_ValueChanged);
            this.PromoCharisma.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Promo_KeyUp);
            // 
            // PromoBody
            // 
            this.PromoBody.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromoBody.Location = new System.Drawing.Point(117, 79);
            this.PromoBody.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PromoBody.Name = "PromoBody";
            this.PromoBody.Size = new System.Drawing.Size(64, 24);
            this.PromoBody.TabIndex = 12;
            this.PromoBody.ValueChanged += new System.EventHandler(this.Promo_ValueChanged);
            this.PromoBody.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Promo_KeyUp);
            // 
            // PromoMechanical
            // 
            this.PromoMechanical.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromoMechanical.Location = new System.Drawing.Point(117, 49);
            this.PromoMechanical.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PromoMechanical.Name = "PromoMechanical";
            this.PromoMechanical.Size = new System.Drawing.Size(64, 24);
            this.PromoMechanical.TabIndex = 11;
            this.PromoMechanical.ValueChanged += new System.EventHandler(this.Promo_ValueChanged);
            this.PromoMechanical.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Promo_KeyUp);
            // 
            // PromoCooking
            // 
            this.PromoCooking.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromoCooking.Location = new System.Drawing.Point(117, 19);
            this.PromoCooking.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PromoCooking.Name = "PromoCooking";
            this.PromoCooking.Size = new System.Drawing.Size(64, 24);
            this.PromoCooking.TabIndex = 10;
            this.PromoCooking.ValueChanged += new System.EventHandler(this.Promo_ValueChanged);
            this.PromoCooking.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Promo_KeyUp);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.PromoList);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(11, 9);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1152, 417);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Job Levels";
            // 
            // PromoList
            // 
            this.PromoList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PrLvl,
            this.PrCooking,
            this.PrMechanical,
            this.PrBody,
            this.PrCharisma,
            this.PrCreativity,
            this.PrLogic,
            this.PrCleaning,
            this.PrFriends,
            this.PrTricks});
            this.PromoList.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromoList.FullRowSelect = true;
            this.PromoList.GridLines = true;
            this.PromoList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.PromoList.HideSelection = false;
            this.PromoList.Location = new System.Drawing.Point(11, 19);
            this.PromoList.MultiSelect = false;
            this.PromoList.Name = "PromoList";
            this.PromoList.Size = new System.Drawing.Size(1130, 389);
            this.PromoList.TabIndex = 14;
            this.PromoList.UseCompatibleStateImageBehavior = false;
            this.PromoList.View = System.Windows.Forms.View.Details;
            this.PromoList.SelectedIndexChanged += new System.EventHandler(this.PromoList_SelectedIndexChanged);
            // 
            // PrLvl
            // 
            this.PrLvl.Text = "Lvl";
            this.PrLvl.Width = 40;
            // 
            // PrCooking
            // 
            this.PrCooking.Text = "Cooking";
            this.PrCooking.Width = 80;
            // 
            // PrMechanical
            // 
            this.PrMechanical.Text = "Mechanical";
            this.PrMechanical.Width = 89;
            // 
            // PrBody
            // 
            this.PrBody.DisplayIndex = 4;
            this.PrBody.Text = "Body";
            this.PrBody.Width = 63;
            // 
            // PrCharisma
            // 
            this.PrCharisma.DisplayIndex = 3;
            this.PrCharisma.Text = "Charisma";
            this.PrCharisma.Width = 80;
            // 
            // PrCreativity
            // 
            this.PrCreativity.Text = "Creativity";
            this.PrCreativity.Width = 80;
            // 
            // PrLogic
            // 
            this.PrLogic.Text = "Logic";
            this.PrLogic.Width = 64;
            // 
            // PrCleaning
            // 
            this.PrCleaning.Text = "Cleaning";
            this.PrCleaning.Width = 80;
            // 
            // PrFriends
            // 
            this.PrFriends.Text = "Family Friends";
            this.PrFriends.Width = 115;
            // 
            // PrTricks
            // 
            this.PrTricks.Text = "Needed Commands";
            this.PrTricks.Width = 148;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.HoursWagesBox);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1176, 712);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hours & Wages";
            // 
            // HoursWagesBox
            // 
            this.HoursWagesBox.Controls.Add(this.WorkSaturday);
            this.HoursWagesBox.Controls.Add(this.WorkFriday);
            this.HoursWagesBox.Controls.Add(this.WorkThursday);
            this.HoursWagesBox.Controls.Add(this.WorkWednesday);
            this.HoursWagesBox.Controls.Add(this.WorkTuesday);
            this.HoursWagesBox.Controls.Add(this.WorkMonday);
            this.HoursWagesBox.Controls.Add(this.WorkSunday);
            this.HoursWagesBox.Controls.Add(this.label100);
            this.HoursWagesBox.Controls.Add(this.label99);
            this.HoursWagesBox.Controls.Add(this.label16);
            this.HoursWagesBox.Controls.Add(this.label15);
            this.HoursWagesBox.Controls.Add(this.label14);
            this.HoursWagesBox.Controls.Add(this.label13);
            this.HoursWagesBox.Controls.Add(this.nudWagesCat);
            this.HoursWagesBox.Controls.Add(this.nudWagesDog);
            this.HoursWagesBox.Controls.Add(this.WorkWages);
            this.HoursWagesBox.Controls.Add(this.WorkFinishHour);
            this.HoursWagesBox.Controls.Add(this.WorkHoursWorked);
            this.HoursWagesBox.Controls.Add(this.WorkStartHour);
            this.HoursWagesBox.Controls.Add(this.groupBox9);
            this.HoursWagesBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.HoursWagesBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursWagesBox.Location = new System.Drawing.Point(11, 437);
            this.HoursWagesBox.Name = "HoursWagesBox";
            this.HoursWagesBox.Size = new System.Drawing.Size(1152, 253);
            this.HoursWagesBox.TabIndex = 18;
            this.HoursWagesBox.TabStop = false;
            this.HoursWagesBox.Text = "Current Level";
            // 
            // WorkSaturday
            // 
            this.WorkSaturday.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WorkSaturday.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkSaturday.Location = new System.Drawing.Point(395, 116);
            this.WorkSaturday.Name = "WorkSaturday";
            this.WorkSaturday.Size = new System.Drawing.Size(64, 20);
            this.WorkSaturday.TabIndex = 19;
            this.WorkSaturday.Text = "Sat";
            this.WorkSaturday.CheckedChanged += new System.EventHandler(this.Workday_CheckedChanged);
            // 
            // WorkFriday
            // 
            this.WorkFriday.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WorkFriday.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkFriday.Location = new System.Drawing.Point(331, 116);
            this.WorkFriday.Name = "WorkFriday";
            this.WorkFriday.Size = new System.Drawing.Size(64, 20);
            this.WorkFriday.TabIndex = 18;
            this.WorkFriday.Text = "Fri";
            this.WorkFriday.CheckedChanged += new System.EventHandler(this.Workday_CheckedChanged);
            // 
            // WorkThursday
            // 
            this.WorkThursday.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WorkThursday.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkThursday.Location = new System.Drawing.Point(267, 116);
            this.WorkThursday.Name = "WorkThursday";
            this.WorkThursday.Size = new System.Drawing.Size(64, 20);
            this.WorkThursday.TabIndex = 17;
            this.WorkThursday.Text = "Thu";
            this.WorkThursday.CheckedChanged += new System.EventHandler(this.Workday_CheckedChanged);
            // 
            // WorkWednesday
            // 
            this.WorkWednesday.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WorkWednesday.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkWednesday.Location = new System.Drawing.Point(203, 116);
            this.WorkWednesday.Name = "WorkWednesday";
            this.WorkWednesday.Size = new System.Drawing.Size(64, 20);
            this.WorkWednesday.TabIndex = 16;
            this.WorkWednesday.Text = "Wed";
            this.WorkWednesday.CheckedChanged += new System.EventHandler(this.Workday_CheckedChanged);
            // 
            // WorkTuesday
            // 
            this.WorkTuesday.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WorkTuesday.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkTuesday.Location = new System.Drawing.Point(139, 116);
            this.WorkTuesday.Name = "WorkTuesday";
            this.WorkTuesday.Size = new System.Drawing.Size(64, 20);
            this.WorkTuesday.TabIndex = 15;
            this.WorkTuesday.Text = "Tue";
            this.WorkTuesday.CheckedChanged += new System.EventHandler(this.Workday_CheckedChanged);
            // 
            // WorkMonday
            // 
            this.WorkMonday.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WorkMonday.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkMonday.Location = new System.Drawing.Point(75, 116);
            this.WorkMonday.Name = "WorkMonday";
            this.WorkMonday.Size = new System.Drawing.Size(64, 20);
            this.WorkMonday.TabIndex = 14;
            this.WorkMonday.Text = "Mon";
            this.WorkMonday.CheckedChanged += new System.EventHandler(this.Workday_CheckedChanged);
            // 
            // WorkSunday
            // 
            this.WorkSunday.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WorkSunday.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkSunday.Location = new System.Drawing.Point(11, 116);
            this.WorkSunday.Name = "WorkSunday";
            this.WorkSunday.Size = new System.Drawing.Size(64, 20);
            this.WorkSunday.TabIndex = 13;
            this.WorkSunday.Text = "Sun";
            this.WorkSunday.CheckedChanged += new System.EventHandler(this.Workday_CheckedChanged);
            // 
            // label100
            // 
            this.label100.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.Location = new System.Drawing.Point(254, 81);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(103, 20);
            this.label100.TabIndex = 12;
            this.label100.Text = "Wages (Cat)";
            // 
            // label99
            // 
            this.label99.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.Location = new System.Drawing.Point(11, 81);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(105, 20);
            this.label99.TabIndex = 12;
            this.label99.Text = "Wages (Dog)";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(11, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 20);
            this.label16.TabIndex = 12;
            this.label16.Text = "Wages";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(348, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 20);
            this.label15.TabIndex = 11;
            this.label15.Text = "Finish";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(200, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "Hours";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 20);
            this.label13.TabIndex = 9;
            this.label13.Text = "Start";
            // 
            // nudWagesCat
            // 
            this.nudWagesCat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWagesCat.Location = new System.Drawing.Point(356, 79);
            this.nudWagesCat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudWagesCat.Name = "nudWagesCat";
            this.nudWagesCat.Size = new System.Drawing.Size(112, 24);
            this.nudWagesCat.TabIndex = 8;
            this.nudWagesCat.ValueChanged += new System.EventHandler(this.Work_ValueChanged);
            this.nudWagesCat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Work_KeyUp);
            // 
            // nudWagesDog
            // 
            this.nudWagesDog.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWagesDog.Location = new System.Drawing.Point(122, 79);
            this.nudWagesDog.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudWagesDog.Name = "nudWagesDog";
            this.nudWagesDog.Size = new System.Drawing.Size(112, 24);
            this.nudWagesDog.TabIndex = 8;
            this.nudWagesDog.ValueChanged += new System.EventHandler(this.Work_ValueChanged);
            this.nudWagesDog.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Work_KeyUp);
            // 
            // WorkWages
            // 
            this.WorkWages.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkWages.Location = new System.Drawing.Point(85, 49);
            this.WorkWages.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.WorkWages.Name = "WorkWages";
            this.WorkWages.Size = new System.Drawing.Size(112, 24);
            this.WorkWages.TabIndex = 8;
            this.WorkWages.ValueChanged += new System.EventHandler(this.Work_ValueChanged);
            this.WorkWages.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Work_KeyUp);
            // 
            // WorkFinishHour
            // 
            this.WorkFinishHour.Enabled = false;
            this.WorkFinishHour.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkFinishHour.Location = new System.Drawing.Point(405, 19);
            this.WorkFinishHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.WorkFinishHour.Name = "WorkFinishHour";
            this.WorkFinishHour.ReadOnly = true;
            this.WorkFinishHour.Size = new System.Drawing.Size(64, 24);
            this.WorkFinishHour.TabIndex = 7;
            // 
            // WorkHoursWorked
            // 
            this.WorkHoursWorked.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkHoursWorked.Location = new System.Drawing.Point(256, 19);
            this.WorkHoursWorked.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.WorkHoursWorked.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WorkHoursWorked.Name = "WorkHoursWorked";
            this.WorkHoursWorked.Size = new System.Drawing.Size(64, 24);
            this.WorkHoursWorked.TabIndex = 6;
            this.WorkHoursWorked.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WorkHoursWorked.ValueChanged += new System.EventHandler(this.Work_ValueChanged);
            this.WorkHoursWorked.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Work_KeyUp);
            // 
            // WorkStartHour
            // 
            this.WorkStartHour.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkStartHour.Location = new System.Drawing.Point(85, 19);
            this.WorkStartHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.WorkStartHour.Name = "WorkStartHour";
            this.WorkStartHour.Size = new System.Drawing.Size(64, 24);
            this.WorkStartHour.TabIndex = 5;
            this.WorkStartHour.ValueChanged += new System.EventHandler(this.Work_ValueChanged);
            this.WorkStartHour.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Work_KeyUp);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label27);
            this.groupBox9.Controls.Add(this.label24);
            this.groupBox9.Controls.Add(this.ComfortHours);
            this.groupBox9.Controls.Add(this.HygieneTotal);
            this.groupBox9.Controls.Add(this.BladderTotal);
            this.groupBox9.Controls.Add(this.label21);
            this.groupBox9.Controls.Add(this.WorkBladder);
            this.groupBox9.Controls.Add(this.label23);
            this.groupBox9.Controls.Add(this.label19);
            this.groupBox9.Controls.Add(this.WorkComfort);
            this.groupBox9.Controls.Add(this.HungerHours);
            this.groupBox9.Controls.Add(this.EnergyHours);
            this.groupBox9.Controls.Add(this.label25);
            this.groupBox9.Controls.Add(this.label18);
            this.groupBox9.Controls.Add(this.WorkPublic);
            this.groupBox9.Controls.Add(this.WorkHunger);
            this.groupBox9.Controls.Add(this.EnvironmentTotal);
            this.groupBox9.Controls.Add(this.BladderHours);
            this.groupBox9.Controls.Add(this.ComfortTotal);
            this.groupBox9.Controls.Add(this.label22);
            this.groupBox9.Controls.Add(this.HungerTotal);
            this.groupBox9.Controls.Add(this.HygieneHours);
            this.groupBox9.Controls.Add(this.ThirstHours);
            this.groupBox9.Controls.Add(this.WorkEnergy);
            this.groupBox9.Controls.Add(this.WorkFun);
            this.groupBox9.Controls.Add(this.WorkThirst);
            this.groupBox9.Controls.Add(this.WorkFamily);
            this.groupBox9.Controls.Add(this.WorkEnvironment);
            this.groupBox9.Controls.Add(this.PublicHours);
            this.groupBox9.Controls.Add(this.label20);
            this.groupBox9.Controls.Add(this.FamilyTotal);
            this.groupBox9.Controls.Add(this.EnergyTotal);
            this.groupBox9.Controls.Add(this.FunTotal);
            this.groupBox9.Controls.Add(this.PublicTotal);
            this.groupBox9.Controls.Add(this.label33);
            this.groupBox9.Controls.Add(this.label32);
            this.groupBox9.Controls.Add(this.label31);
            this.groupBox9.Controls.Add(this.label30);
            this.groupBox9.Controls.Add(this.label29);
            this.groupBox9.Controls.Add(this.label28);
            this.groupBox9.Controls.Add(this.label26);
            this.groupBox9.Controls.Add(this.FunHours);
            this.groupBox9.Controls.Add(this.WorkHygiene);
            this.groupBox9.Controls.Add(this.FamilyHours);
            this.groupBox9.Controls.Add(this.EnvironmentHours);
            this.groupBox9.Controls.Add(this.ThirstTotal);
            this.groupBox9.Location = new System.Drawing.Point(480, 39);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(661, 204);
            this.groupBox9.TabIndex = 12;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Motives";
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(501, 19);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(86, 20);
            this.label27.TabIndex = 64;
            this.label27.Text = "* NoHours";
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(160, 19);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(85, 20);
            this.label24.TabIndex = 41;
            this.label24.Text = "* NoHours";
            // 
            // ComfortHours
            // 
            this.ComfortHours.Enabled = false;
            this.ComfortHours.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComfortHours.Location = new System.Drawing.Point(171, 107);
            this.ComfortHours.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ComfortHours.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.ComfortHours.Name = "ComfortHours";
            this.ComfortHours.ReadOnly = true;
            this.ComfortHours.Size = new System.Drawing.Size(64, 24);
            this.ComfortHours.TabIndex = 29;
            // 
            // HygieneTotal
            // 
            this.HygieneTotal.Enabled = false;
            this.HygieneTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HygieneTotal.Location = new System.Drawing.Point(245, 136);
            this.HygieneTotal.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.HygieneTotal.Minimum = new decimal(new int[] {
            20000,
            0,
            0,
            -2147483648});
            this.HygieneTotal.Name = "HygieneTotal";
            this.HygieneTotal.ReadOnly = true;
            this.HygieneTotal.Size = new System.Drawing.Size(64, 24);
            this.HygieneTotal.TabIndex = 31;
            // 
            // BladderTotal
            // 
            this.BladderTotal.Enabled = false;
            this.BladderTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BladderTotal.Location = new System.Drawing.Point(245, 165);
            this.BladderTotal.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.BladderTotal.Minimum = new decimal(new int[] {
            20000,
            0,
            0,
            -2147483648});
            this.BladderTotal.Name = "BladderTotal";
            this.BladderTotal.ReadOnly = true;
            this.BladderTotal.Size = new System.Drawing.Size(64, 24);
            this.BladderTotal.TabIndex = 30;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(11, 136);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 19);
            this.label21.TabIndex = 38;
            this.label21.Text = "Hygiene";
            // 
            // WorkBladder
            // 
            this.WorkBladder.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkBladder.Location = new System.Drawing.Point(96, 165);
            this.WorkBladder.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.WorkBladder.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.WorkBladder.Name = "WorkBladder";
            this.WorkBladder.Size = new System.Drawing.Size(64, 24);
            this.WorkBladder.TabIndex = 24;
            this.WorkBladder.ValueChanged += new System.EventHandler(this.Work_ValueChanged);
            this.WorkBladder.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Work_KeyUp);
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(96, 19);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(85, 20);
            this.label23.TabIndex = 40;
            this.label23.Text = "PerHour";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(11, 49);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 19);
            this.label19.TabIndex = 36;
            this.label19.Text = "Hunger";
            // 
            // WorkComfort
            // 
            this.WorkComfort.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkComfort.Location = new System.Drawing.Point(96, 107);
            this.WorkComfort.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.WorkComfort.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.WorkComfort.Name = "WorkComfort";
            this.WorkComfort.Size = new System.Drawing.Size(64, 24);
            this.WorkComfort.TabIndex = 22;
            this.WorkComfort.ValueChanged += new System.EventHandler(this.Work_ValueChanged);
            this.WorkComfort.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Work_KeyUp);
            // 
            // HungerHours
            // 
            this.HungerHours.Enabled = false;
            this.HungerHours.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HungerHours.Location = new System.Drawing.Point(171, 49);
            this.HungerHours.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.HungerHours.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.HungerHours.Name = "HungerHours";
            this.HungerHours.ReadOnly = true;
            this.HungerHours.Size = new System.Drawing.Size(64, 24);
            this.HungerHours.TabIndex = 27;
            // 
            // EnergyHours
            // 
            this.EnergyHours.Enabled = false;
            this.EnergyHours.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnergyHours.Location = new System.Drawing.Point(512, 49);
            this.EnergyHours.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.EnergyHours.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.EnergyHours.Name = "EnergyHours";
            this.EnergyHours.ReadOnly = true;
            this.EnergyHours.Size = new System.Drawing.Size(64, 24);
            this.EnergyHours.TabIndex = 50;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(245, 19);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(75, 20);
            this.label25.TabIndex = 42;
            this.label25.Text = "= Total";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(11, 78);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 19);
            this.label18.TabIndex = 35;
            this.label18.Text = "Thirst";
            // 
            // WorkPublic
            // 
            this.WorkPublic.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkPublic.Location = new System.Drawing.Point(437, 107);
            this.WorkPublic.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.WorkPublic.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.WorkPublic.Name = "WorkPublic";
            this.WorkPublic.Size = new System.Drawing.Size(64, 24);
            this.WorkPublic.TabIndex = 45;
            this.WorkPublic.ValueChanged += new System.EventHandler(this.Work_ValueChanged);
            this.WorkPublic.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Work_KeyUp);
            // 
            // WorkHunger
            // 
            this.WorkHunger.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkHunger.Location = new System.Drawing.Point(96, 49);
            this.WorkHunger.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.WorkHunger.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.WorkHunger.Name = "WorkHunger";
            this.WorkHunger.Size = new System.Drawing.Size(64, 24);
            this.WorkHunger.TabIndex = 20;
            this.WorkHunger.ValueChanged += new System.EventHandler(this.Work_ValueChanged);
            this.WorkHunger.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Work_KeyUp);
            // 
            // EnvironmentTotal
            // 
            this.EnvironmentTotal.Enabled = false;
            this.EnvironmentTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnvironmentTotal.Location = new System.Drawing.Point(587, 165);
            this.EnvironmentTotal.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.EnvironmentTotal.Minimum = new decimal(new int[] {
            20000,
            0,
            0,
            -2147483648});
            this.EnvironmentTotal.Name = "EnvironmentTotal";
            this.EnvironmentTotal.ReadOnly = true;
            this.EnvironmentTotal.Size = new System.Drawing.Size(64, 24);
            this.EnvironmentTotal.TabIndex = 53;
            // 
            // BladderHours
            // 
            this.BladderHours.Enabled = false;
            this.BladderHours.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BladderHours.Location = new System.Drawing.Point(171, 165);
            this.BladderHours.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.BladderHours.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.BladderHours.Name = "BladderHours";
            this.BladderHours.ReadOnly = true;
            this.BladderHours.Size = new System.Drawing.Size(64, 24);
            this.BladderHours.TabIndex = 25;
            // 
            // ComfortTotal
            // 
            this.ComfortTotal.Enabled = false;
            this.ComfortTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComfortTotal.Location = new System.Drawing.Point(245, 107);
            this.ComfortTotal.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.ComfortTotal.Minimum = new decimal(new int[] {
            20000,
            0,
            0,
            -2147483648});
            this.ComfortTotal.Name = "ComfortTotal";
            this.ComfortTotal.ReadOnly = true;
            this.ComfortTotal.Size = new System.Drawing.Size(64, 24);
            this.ComfortTotal.TabIndex = 34;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(11, 165);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 20);
            this.label22.TabIndex = 39;
            this.label22.Text = "Bladder";
            // 
            // HungerTotal
            // 
            this.HungerTotal.Enabled = false;
            this.HungerTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HungerTotal.Location = new System.Drawing.Point(245, 49);
            this.HungerTotal.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.HungerTotal.Minimum = new decimal(new int[] {
            20000,
            0,
            0,
            -2147483648});
            this.HungerTotal.Name = "HungerTotal";
            this.HungerTotal.ReadOnly = true;
            this.HungerTotal.Size = new System.Drawing.Size(64, 24);
            this.HungerTotal.TabIndex = 32;
            // 
            // HygieneHours
            // 
            this.HygieneHours.Enabled = false;
            this.HygieneHours.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HygieneHours.Location = new System.Drawing.Point(171, 136);
            this.HygieneHours.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.HygieneHours.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.HygieneHours.Name = "HygieneHours";
            this.HygieneHours.ReadOnly = true;
            this.HygieneHours.Size = new System.Drawing.Size(64, 24);
            this.HygieneHours.TabIndex = 26;
            // 
            // ThirstHours
            // 
            this.ThirstHours.Enabled = false;
            this.ThirstHours.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirstHours.Location = new System.Drawing.Point(171, 78);
            this.ThirstHours.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ThirstHours.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.ThirstHours.Name = "ThirstHours";
            this.ThirstHours.ReadOnly = true;
            this.ThirstHours.Size = new System.Drawing.Size(64, 24);
            this.ThirstHours.TabIndex = 28;
            // 
            // WorkEnergy
            // 
            this.WorkEnergy.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkEnergy.Location = new System.Drawing.Point(437, 49);
            this.WorkEnergy.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.WorkEnergy.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.WorkEnergy.Name = "WorkEnergy";
            this.WorkEnergy.Size = new System.Drawing.Size(64, 24);
            this.WorkEnergy.TabIndex = 43;
            this.WorkEnergy.ValueChanged += new System.EventHandler(this.Work_ValueChanged);
            this.WorkEnergy.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Work_KeyUp);
            // 
            // WorkFun
            // 
            this.WorkFun.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkFun.Location = new System.Drawing.Point(437, 78);
            this.WorkFun.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.WorkFun.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.WorkFun.Name = "WorkFun";
            this.WorkFun.Size = new System.Drawing.Size(64, 24);
            this.WorkFun.TabIndex = 44;
            this.WorkFun.ValueChanged += new System.EventHandler(this.Work_ValueChanged);
            this.WorkFun.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Work_KeyUp);
            // 
            // WorkThirst
            // 
            this.WorkThirst.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkThirst.Location = new System.Drawing.Point(96, 78);
            this.WorkThirst.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.WorkThirst.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.WorkThirst.Name = "WorkThirst";
            this.WorkThirst.Size = new System.Drawing.Size(64, 24);
            this.WorkThirst.TabIndex = 21;
            this.WorkThirst.ValueChanged += new System.EventHandler(this.Work_ValueChanged);
            this.WorkThirst.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Work_KeyUp);
            // 
            // WorkFamily
            // 
            this.WorkFamily.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkFamily.Location = new System.Drawing.Point(437, 136);
            this.WorkFamily.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.WorkFamily.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.WorkFamily.Name = "WorkFamily";
            this.WorkFamily.Size = new System.Drawing.Size(64, 24);
            this.WorkFamily.TabIndex = 46;
            this.WorkFamily.ValueChanged += new System.EventHandler(this.Work_ValueChanged);
            this.WorkFamily.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Work_KeyUp);
            // 
            // WorkEnvironment
            // 
            this.WorkEnvironment.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkEnvironment.Location = new System.Drawing.Point(437, 165);
            this.WorkEnvironment.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.WorkEnvironment.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.WorkEnvironment.Name = "WorkEnvironment";
            this.WorkEnvironment.Size = new System.Drawing.Size(64, 24);
            this.WorkEnvironment.TabIndex = 47;
            this.WorkEnvironment.ValueChanged += new System.EventHandler(this.Work_ValueChanged);
            this.WorkEnvironment.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Work_KeyUp);
            // 
            // PublicHours
            // 
            this.PublicHours.Enabled = false;
            this.PublicHours.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublicHours.Location = new System.Drawing.Point(512, 107);
            this.PublicHours.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PublicHours.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.PublicHours.Name = "PublicHours";
            this.PublicHours.ReadOnly = true;
            this.PublicHours.Size = new System.Drawing.Size(64, 24);
            this.PublicHours.TabIndex = 52;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(11, 107);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 19);
            this.label20.TabIndex = 37;
            this.label20.Text = "Comfort";
            // 
            // FamilyTotal
            // 
            this.FamilyTotal.Enabled = false;
            this.FamilyTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamilyTotal.Location = new System.Drawing.Point(587, 136);
            this.FamilyTotal.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.FamilyTotal.Minimum = new decimal(new int[] {
            20000,
            0,
            0,
            -2147483648});
            this.FamilyTotal.Name = "FamilyTotal";
            this.FamilyTotal.ReadOnly = true;
            this.FamilyTotal.Size = new System.Drawing.Size(64, 24);
            this.FamilyTotal.TabIndex = 54;
            // 
            // EnergyTotal
            // 
            this.EnergyTotal.Enabled = false;
            this.EnergyTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnergyTotal.Location = new System.Drawing.Point(587, 49);
            this.EnergyTotal.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.EnergyTotal.Minimum = new decimal(new int[] {
            20000,
            0,
            0,
            -2147483648});
            this.EnergyTotal.Name = "EnergyTotal";
            this.EnergyTotal.ReadOnly = true;
            this.EnergyTotal.Size = new System.Drawing.Size(64, 24);
            this.EnergyTotal.TabIndex = 55;
            // 
            // FunTotal
            // 
            this.FunTotal.Enabled = false;
            this.FunTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FunTotal.Location = new System.Drawing.Point(587, 78);
            this.FunTotal.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.FunTotal.Minimum = new decimal(new int[] {
            20000,
            0,
            0,
            -2147483648});
            this.FunTotal.Name = "FunTotal";
            this.FunTotal.ReadOnly = true;
            this.FunTotal.Size = new System.Drawing.Size(64, 24);
            this.FunTotal.TabIndex = 56;
            // 
            // PublicTotal
            // 
            this.PublicTotal.Enabled = false;
            this.PublicTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublicTotal.Location = new System.Drawing.Point(587, 107);
            this.PublicTotal.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.PublicTotal.Minimum = new decimal(new int[] {
            20000,
            0,
            0,
            -2147483648});
            this.PublicTotal.Name = "PublicTotal";
            this.PublicTotal.ReadOnly = true;
            this.PublicTotal.Size = new System.Drawing.Size(64, 24);
            this.PublicTotal.TabIndex = 57;
            // 
            // label33
            // 
            this.label33.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(320, 78);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(96, 19);
            this.label33.TabIndex = 58;
            this.label33.Text = "Fun";
            // 
            // label32
            // 
            this.label32.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(320, 49);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(96, 19);
            this.label32.TabIndex = 59;
            this.label32.Text = "Energy";
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(320, 107);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(107, 19);
            this.label31.TabIndex = 60;
            this.label31.Text = "Social Public";
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(320, 136);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(107, 19);
            this.label30.TabIndex = 61;
            this.label30.Text = "Social Family";
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(320, 165);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(107, 20);
            this.label29.TabIndex = 62;
            this.label29.Text = "Environment";
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(437, 19);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(75, 20);
            this.label28.TabIndex = 63;
            this.label28.Text = "PerHour";
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(587, 19);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(64, 20);
            this.label26.TabIndex = 65;
            this.label26.Text = "= Total";
            // 
            // FunHours
            // 
            this.FunHours.Enabled = false;
            this.FunHours.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FunHours.Location = new System.Drawing.Point(512, 78);
            this.FunHours.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.FunHours.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.FunHours.Name = "FunHours";
            this.FunHours.ReadOnly = true;
            this.FunHours.Size = new System.Drawing.Size(64, 24);
            this.FunHours.TabIndex = 51;
            // 
            // WorkHygiene
            // 
            this.WorkHygiene.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkHygiene.Location = new System.Drawing.Point(96, 136);
            this.WorkHygiene.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.WorkHygiene.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.WorkHygiene.Name = "WorkHygiene";
            this.WorkHygiene.Size = new System.Drawing.Size(64, 24);
            this.WorkHygiene.TabIndex = 23;
            this.WorkHygiene.ValueChanged += new System.EventHandler(this.Work_ValueChanged);
            this.WorkHygiene.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Work_KeyUp);
            // 
            // FamilyHours
            // 
            this.FamilyHours.Enabled = false;
            this.FamilyHours.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamilyHours.Location = new System.Drawing.Point(512, 136);
            this.FamilyHours.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.FamilyHours.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.FamilyHours.Name = "FamilyHours";
            this.FamilyHours.ReadOnly = true;
            this.FamilyHours.Size = new System.Drawing.Size(64, 24);
            this.FamilyHours.TabIndex = 49;
            // 
            // EnvironmentHours
            // 
            this.EnvironmentHours.Enabled = false;
            this.EnvironmentHours.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnvironmentHours.Location = new System.Drawing.Point(512, 165);
            this.EnvironmentHours.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.EnvironmentHours.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.EnvironmentHours.Name = "EnvironmentHours";
            this.EnvironmentHours.ReadOnly = true;
            this.EnvironmentHours.Size = new System.Drawing.Size(64, 24);
            this.EnvironmentHours.TabIndex = 48;
            // 
            // ThirstTotal
            // 
            this.ThirstTotal.Enabled = false;
            this.ThirstTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirstTotal.Location = new System.Drawing.Point(245, 78);
            this.ThirstTotal.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.ThirstTotal.Minimum = new decimal(new int[] {
            20000,
            0,
            0,
            -2147483648});
            this.ThirstTotal.Name = "ThirstTotal";
            this.ThirstTotal.ReadOnly = true;
            this.ThirstTotal.Size = new System.Drawing.Size(64, 24);
            this.ThirstTotal.TabIndex = 33;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.HoursWagesList);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(11, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1152, 417);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Job Levels";
            // 
            // HoursWagesList
            // 
            this.HoursWagesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HwLvl,
            this.HwStart,
            this.HwHours,
            this.HwEnd,
            this.HwWages,
            this.HwDogWages,
            this.HwCatWages,
            this.HwSun,
            this.HwMon,
            this.HwTue,
            this.HwWed,
            this.HwThu,
            this.HwFri,
            this.HwSat});
            this.HoursWagesList.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursWagesList.FullRowSelect = true;
            this.HoursWagesList.GridLines = true;
            this.HoursWagesList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.HoursWagesList.HideSelection = false;
            this.HoursWagesList.Location = new System.Drawing.Point(11, 19);
            this.HoursWagesList.MultiSelect = false;
            this.HoursWagesList.Name = "HoursWagesList";
            this.HoursWagesList.Size = new System.Drawing.Size(1130, 389);
            this.HoursWagesList.TabIndex = 13;
            this.HoursWagesList.UseCompatibleStateImageBehavior = false;
            this.HoursWagesList.View = System.Windows.Forms.View.Details;
            this.HoursWagesList.SelectedIndexChanged += new System.EventHandler(this.HoursWagesList_SelectedIndexChanged);
            // 
            // HwLvl
            // 
            this.HwLvl.Text = "Lvl";
            this.HwLvl.Width = 40;
            // 
            // HwStart
            // 
            this.HwStart.Text = "Start";
            this.HwStart.Width = 80;
            // 
            // HwHours
            // 
            this.HwHours.Text = "Hours";
            this.HwHours.Width = 80;
            // 
            // HwEnd
            // 
            this.HwEnd.Text = "End";
            this.HwEnd.Width = 80;
            // 
            // HwWages
            // 
            this.HwWages.Text = "Wages";
            this.HwWages.Width = 65;
            // 
            // HwDogWages
            // 
            this.HwDogWages.Text = "Wages (Dog)";
            this.HwDogWages.Width = 107;
            // 
            // HwCatWages
            // 
            this.HwCatWages.Text = "Wages (Cat)";
            this.HwCatWages.Width = 104;
            // 
            // HwSun
            // 
            this.HwSun.Text = "Sun";
            // 
            // HwMon
            // 
            this.HwMon.Text = "Mon";
            // 
            // HwTue
            // 
            this.HwTue.Text = "Tue";
            // 
            // HwWed
            // 
            this.HwWed.Text = "Wed";
            // 
            // HwThu
            // 
            this.HwThu.Text = "Thu";
            // 
            // HwFri
            // 
            this.HwFri.Text = "Fri";
            // 
            // HwSat
            // 
            this.HwSat.Text = "Sat";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.ItemSize = new System.Drawing.Size(64, 18);
            this.tabControl1.Location = new System.Drawing.Point(11, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1184, 738);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.JobDetailsBox);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1176, 712);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Job Details";
            // 
            // JobDetailsBox
            // 
            this.JobDetailsBox.Controls.Add(this.JobDetailsCopy);
            this.JobDetailsBox.Controls.Add(this.label9);
            this.JobDetailsBox.Controls.Add(this.label8);
            this.JobDetailsBox.Controls.Add(this.Vehicle);
            this.JobDetailsBox.Controls.Add(this.Outfit);
            this.JobDetailsBox.Controls.Add(this.JobDescFemale);
            this.JobDetailsBox.Controls.Add(this.JobTitleFemale);
            this.JobDetailsBox.Controls.Add(this.label6);
            this.JobDetailsBox.Controls.Add(this.label7);
            this.JobDetailsBox.Controls.Add(this.JobDescMale);
            this.JobDetailsBox.Controls.Add(this.JobTitleMale);
            this.JobDetailsBox.Controls.Add(this.label5);
            this.JobDetailsBox.Controls.Add(this.label4);
            this.JobDetailsBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.JobDetailsBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobDetailsBox.Location = new System.Drawing.Point(11, 437);
            this.JobDetailsBox.Name = "JobDetailsBox";
            this.JobDetailsBox.Size = new System.Drawing.Size(1152, 262);
            this.JobDetailsBox.TabIndex = 16;
            this.JobDetailsBox.TabStop = false;
            this.JobDetailsBox.Text = "Current Level";
            // 
            // JobDetailsCopy
            // 
            this.JobDetailsCopy.AutoSize = true;
            this.JobDetailsCopy.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobDetailsCopy.Location = new System.Drawing.Point(587, 136);
            this.JobDetailsCopy.Name = "JobDetailsCopy";
            this.JobDetailsCopy.Size = new System.Drawing.Size(72, 17);
            this.JobDetailsCopy.TabIndex = 13;
            this.JobDetailsCopy.TabStop = true;
            this.JobDetailsCopy.Text = "Copy ->";
            this.JobDetailsCopy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.JobDetailsCopy_LinkClicked);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(565, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Vehicle";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Outfit";
            // 
            // Vehicle
            // 
            this.Vehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Vehicle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehicle.Location = new System.Drawing.Point(683, 233);
            this.Vehicle.Name = "Vehicle";
            this.Vehicle.Size = new System.Drawing.Size(277, 25);
            this.Vehicle.TabIndex = 10;
            this.Vehicle.SelectedIndexChanged += new System.EventHandler(this.Vehicle_SelectedIndexChanged);
            // 
            // Outfit
            // 
            this.Outfit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Outfit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outfit.Location = new System.Drawing.Point(107, 233);
            this.Outfit.Name = "Outfit";
            this.Outfit.Size = new System.Drawing.Size(266, 25);
            this.Outfit.TabIndex = 9;
            this.Outfit.SelectedIndexChanged += new System.EventHandler(this.Outfit_SelectedIndexChanged);
            // 
            // JobDescFemale
            // 
            this.JobDescFemale.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobDescFemale.Location = new System.Drawing.Point(683, 49);
            this.JobDescFemale.Multiline = true;
            this.JobDescFemale.Name = "JobDescFemale";
            this.JobDescFemale.Size = new System.Drawing.Size(458, 174);
            this.JobDescFemale.TabIndex = 7;
            this.JobDescFemale.Text = "JobDescFemale";
            this.JobDescFemale.TextChanged += new System.EventHandler(this.JobDescFemale_TextChanged);
            // 
            // JobTitleFemale
            // 
            this.JobTitleFemale.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobTitleFemale.Location = new System.Drawing.Point(683, 19);
            this.JobTitleFemale.Name = "JobTitleFemale";
            this.JobTitleFemale.Size = new System.Drawing.Size(458, 24);
            this.JobTitleFemale.TabIndex = 6;
            this.JobTitleFemale.Text = "JobTitleFemale";
            this.JobTitleFemale.TextChanged += new System.EventHandler(this.JobTitleFemale_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(565, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Desc Female";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(565, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Title Female";
            // 
            // JobDescMale
            // 
            this.JobDescMale.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobDescMale.Location = new System.Drawing.Point(107, 49);
            this.JobDescMale.Multiline = true;
            this.JobDescMale.Name = "JobDescMale";
            this.JobDescMale.Size = new System.Drawing.Size(458, 174);
            this.JobDescMale.TabIndex = 3;
            this.JobDescMale.Text = "JobDescMale";
            this.JobDescMale.TextChanged += new System.EventHandler(this.JobDescMale_TextChanged);
            // 
            // JobTitleMale
            // 
            this.JobTitleMale.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobTitleMale.Location = new System.Drawing.Point(107, 19);
            this.JobTitleMale.Name = "JobTitleMale";
            this.JobTitleMale.Size = new System.Drawing.Size(458, 24);
            this.JobTitleMale.TabIndex = 2;
            this.JobTitleMale.Text = "JobTitleMale";
            this.JobTitleMale.TextChanged += new System.EventHandler(this.JobTitleMale_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Desc Male";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Title Male";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.JobDetailList);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1152, 417);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Job Levels";
            // 
            // JobDetailList
            // 
            this.JobDetailList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.JdLvl,
            this.JdJobTitle,
            this.JdDesc,
            this.JdOutfit,
            this.JdVehicle});
            this.JobDetailList.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobDetailList.FullRowSelect = true;
            this.JobDetailList.GridLines = true;
            this.JobDetailList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.JobDetailList.HideSelection = false;
            this.JobDetailList.Location = new System.Drawing.Point(11, 19);
            this.JobDetailList.MultiSelect = false;
            this.JobDetailList.Name = "JobDetailList";
            this.JobDetailList.Size = new System.Drawing.Size(1130, 389);
            this.JobDetailList.TabIndex = 8;
            this.JobDetailList.UseCompatibleStateImageBehavior = false;
            this.JobDetailList.View = System.Windows.Forms.View.Details;
            this.JobDetailList.SelectedIndexChanged += new System.EventHandler(this.JobDetailList_SelectedIndexChanged);
            // 
            // JdLvl
            // 
            this.JdLvl.Text = "Lvl";
            this.JdLvl.Width = 40;
            // 
            // JdJobTitle
            // 
            this.JdJobTitle.Text = "Job Title";
            this.JdJobTitle.Width = 110;
            // 
            // JdDesc
            // 
            this.JdDesc.Text = "Job Description";
            this.JdDesc.Width = 494;
            // 
            // JdOutfit
            // 
            this.JdOutfit.Text = "Outfit";
            this.JdOutfit.Width = 100;
            // 
            // JdVehicle
            // 
            this.JdVehicle.Text = "Vehicle";
            this.JdVehicle.Width = 100;
            // 
            // CareerLvls
            // 
            this.CareerLvls.Enabled = false;
            this.CareerLvls.Location = new System.Drawing.Point(437, 1);
            this.CareerLvls.Name = "CareerLvls";
            this.CareerLvls.ReadOnly = true;
            this.CareerLvls.Size = new System.Drawing.Size(64, 24);
            this.CareerLvls.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(345, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Career Lvls";
            // 
            // CareerTitle
            // 
            this.CareerTitle.Location = new System.Drawing.Point(128, 0);
            this.CareerTitle.Name = "CareerTitle";
            this.CareerTitle.Size = new System.Drawing.Size(203, 24);
            this.CareerTitle.TabIndex = 11;
            this.CareerTitle.TextChanged += new System.EventHandler(this.CareerTitle_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Career Title";
            // 
            // Language
            // 
            this.Language.Location = new System.Drawing.Point(928, 0);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(245, 25);
            this.Language.TabIndex = 15;
            this.Language.Text = "01 - English";
            this.Language.SelectedIndexChanged += new System.EventHandler(this.Language_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(837, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "Language";
            // 
            // label102
            // 
            this.label102.Location = new System.Drawing.Point(538, 3);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(64, 19);
            this.label102.TabIndex = 18;
            this.label102.Text = "Reward";
            // 
            // CareerReward
            // 
            this.CareerReward.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CareerReward.Location = new System.Drawing.Point(608, 0);
            this.CareerReward.Name = "CareerReward";
            this.CareerReward.Size = new System.Drawing.Size(213, 25);
            this.CareerReward.TabIndex = 17;
            this.CareerReward.SelectedIndexChanged += new System.EventHandler(this.CareerReward_SelectedIndexChanged);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem6,
            this.menuItem1});
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 0;
            this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem7,
            this.menuItem8,
            this.menuItem9});
            this.menuItem6.Text = "&Levels";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 0;
            this.menuItem7.Text = "&Insert Level";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 1;
            this.menuItem8.Text = "&Remove Level";
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Enabled = false;
            this.menuItem9.Index = 2;
            this.menuItem9.Text = "&Copy Level...";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem3,
            this.menuItem4,
            this.menuItem5});
            this.menuItem1.Text = "L&anguages";
            // 
            // menuItem2
            // 
            this.menuItem2.Checked = true;
            this.menuItem2.Enabled = false;
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "&One English";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "&English Only";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Text = "-";
            // 
            // menuItem5
            // 
            this.menuItem5.Enabled = false;
            this.menuItem5.Index = 3;
            this.menuItem5.Text = "&Copy...";
            // 
            // CareerEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1220, 772);
            this.Controls.Add(this.CareerTitle);
            this.Controls.Add(this.label102);
            this.Controls.Add(this.CareerReward);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CareerLvls);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Menu = this.mainMenu1;
            this.Name = "CareerEditor";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.ShowInTaskbar = false;
            this.Text = "Career Editor (by Bidou)";
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChanceCurrentLevel)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassAJobLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassAMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassACleaning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassALogic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassACreativity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassABody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassACharisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassAMechanical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassACooking)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FailAJobLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailAMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailACleaning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailALogic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailACreativity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailABody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailACharisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailAMechanical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailACooking)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassBJobLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassBMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassBCleaning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassBLogic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassBCreativity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassBBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassBCharisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassBMechanical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassBCooking)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FailBJobLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailBMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailBCleaning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailBLogic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailBCreativity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailBBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailBCharisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailBMechanical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailBCooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceBCleaning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceBLogic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceBCreativity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceBBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceBCharisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceBMechanical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceBCooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceACleaning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceALogic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceACreativity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceABody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceACharisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceAMechanical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceACooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChancePercent)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.PromoBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPromoTricks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromoFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromoCleaning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromoLogic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromoCreativity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromoCharisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromoBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromoMechanical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromoCooking)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.HoursWagesBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudWagesCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWagesDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkWages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkFinishHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkHoursWorked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkStartHour)).EndInit();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComfortHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HygieneTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BladderTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkBladder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkComfort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HungerHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnergyHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkPublic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkHunger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnvironmentTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BladderHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComfortTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HungerTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HygieneHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirstHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkEnergy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkFun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkThirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkFamily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkEnvironment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PublicHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FamilyTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnergyTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PublicTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkHygiene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FamilyHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnvironmentHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirstTotal)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.JobDetailsBox.ResumeLayout(false);
            this.JobDetailsBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CareerLvls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private bool internalchg = false;
		public Interfaces.Plugin.IToolResult Execute(ref SimPe.Interfaces.Files.IPackedFileDescriptor pfd, ref SimPe.Interfaces.Files.IPackageFile package, Interfaces.IProviderRegistry prov) 
		{
			bool newpackage = false;

			this.package = (SimPe.Packages.GeneratableFile)package;
			
			
			WaitingScreen.Wait();
			try 
			{
				if (this.package==null) 
				{
					this.package = SimPe.Packages.GeneratableFile.LoadFromFile(CareerTool.DefaultCareerFile);					
					newpackage = true;
					this.package = (SimPe.Packages.GeneratableFile)this.package.Clone();
				}
				loadFiles();
				
				//menuItem2.Checked = oneEnglish;
				menuItem3.Checked = englishOnly;

                languageString = new ArrayList();
				languageID = new ArrayList();
				for (int i = 0; i < catalogueDesc.Languages.Length; i++)
				{
					SimPe.PackedFiles.Wrapper.StrLanguage l = catalogueDesc.Languages[i];
					if (l.Id != 2)
					{
						languageString.Insert(0, languageStringsMaster[l.Id]);
						languageID.Insert(0, l.Id);
					}
				}

                internalchg = true;

                Language.DataSource = languageString;
				Outfit.DataSource = outfitStrings;
				Vehicle.DataSource = vehicleStrings;

                internalchg = false;

                currentLanguage = new SimPe.PackedFiles.Wrapper.StrLanguage(1);
				currentLevel = 1;

				//SimPe.PackedFiles.Wrapper.StrItem[] items = catalogueDesc.FallbackedLanguageItems(Helper.WindowsRegistry.LanguageCode);
				SimPe.PackedFiles.Wrapper.StrItemList items = catalogueDesc.LanguageItems(currentLanguage);

				CareerTitle.Text = items[0].Title;

				noLevelsChanged((ushort)tuning[0]);

				if(BHavReward.FileName == "CT - Career Reward")
				{

					byte a = BHavReward[2].Operands[5];
					byte b = BHavReward[2].Operands[6];
					byte c = BHavReward[2].Operands[7];
					byte d = BHavReward[2].Reserved1[0];

					hasReward = true;
					CareerReward.DataSource = rewardStrings;
					
					setRewardFromGUID(a, b, c, d);
				}
				else
				{
					byte a = BHavReward[1].Operands[0];
					byte b = BHavReward[1].Operands[1];
					byte c = BHavReward[1].Operands[2];
					byte d = BHavReward[1].Operands[3];

					hasReward = false;
					CareerReward.DataSource = adultStrings;
					label102.Text = "Adult";

					setRewardFromGUID(a, b, c, d);
				}

				levelChanged();
			}
			catch (Exception e)
			{
				Helper.ExceptionMessage("Error Loading Career", e);
				return new Plugin.ToolResult(false, false);
			} 
			finally 
			{
				WaitingScreen.Stop(this);
			}

			ShowDialog();
			getChanceCardValues();

			if (englishOnly)
				removeOtherLanguages();
			if (oneEnglish)
				removeEnglishInternational();

			saveFiles();
			XmlRegistryKey rk = Helper.WindowsRegistry.PluginRegistryKey.CreateSubKey("CareerEditor");

			rk.SetValue("oneEnglish", oneEnglish);
			rk.SetValue("englishOnly", englishOnly);

			if (newpackage) package = this.package;
			return new Plugin.ToolResult(true, newpackage);
		}

		private void removeEnglishInternational()
		{
			SimPe.PackedFiles.Wrapper.StrLanguage l = new SimPe.PackedFiles.Wrapper.StrLanguage(2);
			SimPe.PackedFiles.Wrapper.StrItemList items = jobTitles.LanguageItems(l);
			for (int j = 0; j < items.Length; j++)
			{
				items[j].Title = "";
			}

			items = chanceCardsText.LanguageItems(l);
			for (int j = 0; j < items.Length; j++)
			{
				items[j].Title = "";
			}

			items = catalogueDesc.LanguageItems(l);
			for (int j = 0; j < items.Length; j++)
			{
				items[j].Title = "";
			}
		}

		private void removeOtherLanguages()
		{
			for (int i = 0; i < jobTitles.Languages.Length; i++)
				if (jobTitles.Languages[i].Id > 2)
				{
					SimPe.PackedFiles.Wrapper.StrLanguage l = new SimPe.PackedFiles.Wrapper.StrLanguage(jobTitles.Languages[i].Id);
					SimPe.PackedFiles.Wrapper.StrItemList items = jobTitles.LanguageItems(l);
					for (int j = 0; j < items.Length; j++)
					{
						items[j].Title = "";
					}
				}

			for (int i = 0; i < chanceCardsText.Languages.Length; i++)
				if (chanceCardsText.Languages[i].Id > 2)
				{
					SimPe.PackedFiles.Wrapper.StrLanguage l = new SimPe.PackedFiles.Wrapper.StrLanguage(chanceCardsText.Languages[i].Id);
					SimPe.PackedFiles.Wrapper.StrItemList items = chanceCardsText.LanguageItems(l);
					for (int j = 0; j < items.Length; j++)
					{
						items[j].Title = "";
					}
				}

			for (int i = 0; i < catalogueDesc.Languages.Length; i++)
				if (catalogueDesc.Languages[i].Id > 2)
				{
					SimPe.PackedFiles.Wrapper.StrLanguage l = new SimPe.PackedFiles.Wrapper.StrLanguage(catalogueDesc.Languages[i].Id);
					SimPe.PackedFiles.Wrapper.StrItemList items = catalogueDesc.LanguageItems(l);
					for (int j = 0; j < items.Length; j++)
					{
						items[j].Title = "";
					}
				}
		}

		private void fillJobDetails()
		{
			JobDetailList.Items.Clear();
			SimPe.PackedFiles.Wrapper.StrItemList items = jobTitles.LanguageItems(currentLanguage);
			for (ushort i = 1; i <= noLevels; i++)
			{
				ListViewItem item1 = new ListViewItem(""+i,0);
				item1.SubItems.Add(items[i * 2 - 1].Title);
				item1.SubItems.Add(items[i * 2].Title);
				item1.SubItems.Add(getOutfitTextFromGUID(outfitGUID[i * 2], outfitGUID[i * 2 + 1]));
				item1.SubItems.Add(getVehicleTextFromGUID(vehicleGUID[i * 2], vehicleGUID[i * 2 + 1]));
				JobDetailList.Items.Add(item1);
			}
		}

		private void fillHoursAndWages()
		{
			HoursWagesList.Items.Clear();
			for (ushort i = 1; i <= noLevels; i++)
			{
				ListViewItem item1 = new ListViewItem(""+i,0);

				item1.SubItems.Add(""+startHour[i]);
				item1.SubItems.Add(""+hoursWorked[i]);
				item1.SubItems.Add(""+(startHour[i] + hoursWorked[i]) % 24);
                if (wages != null)
                {
				    item1.SubItems.Add(""+wages[i]);
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                }
                else
                {
                    item1.SubItems.Add("");
                    item1.SubItems.Add("" + wagesDog[i]);
                    item1.SubItems.Add("" + wagesCat[i]);
                }

				bool[] days = getDaysArray(daysWorked[i]);
				item1.SubItems.Add(""+days[SUNDAY]);
				item1.SubItems.Add(""+days[MONDAY]);
				item1.SubItems.Add(""+days[TUESDAY]);
				item1.SubItems.Add(""+days[WEDNESDAY]);
				item1.SubItems.Add(""+days[THURSDAY]);
				item1.SubItems.Add(""+days[FRIDAY]);
				item1.SubItems.Add(""+days[SATURDAY]);

				HoursWagesList.Items.Add(item1);
			}
		}

		private void fillPromotionDetails()
		{
			PromoList.Items.Clear();
			for (ushort i = 1; i <= noLevels; i++)
			{
				ListViewItem item1 = new ListViewItem(""+i,0);

                if (skillReq[BODY] != null) // the first two are something else for Pets
                {
                    item1.SubItems.Add("" + skillReq[COOKING][i] / 100);
                    item1.SubItems.Add("" + skillReq[MECHANICAL][i] / 100);
                    item1.SubItems.Add("" + skillReq[CHARISMA][i] / 100);
                    item1.SubItems.Add("" + skillReq[BODY][i] / 100);
                    item1.SubItems.Add("" + skillReq[CREATIVITY][i] / 100);
                    item1.SubItems.Add("" + skillReq[LOGIC][i] / 100);
                    item1.SubItems.Add("" + skillReq[CLEANING][i] / 100);
                    item1.SubItems.Add("" + friends[i]);
                    item1.SubItems.Add("");
                }
                else
                {
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems.Add("" + friends[i]);
                    item1.SubItems.Add("" + tricks[i]);
                }

				PromoList.Items.Add(item1);
			}
		}
		private void fillChanceCards()
		{
			SimPe.PackedFiles.Wrapper.StrItemList items = chanceCardsText.LanguageItems(currentLanguage);

			ChoiceA.Text = items[currentLevel * 12 + 7].Title;
			ChoiceB.Text = items[currentLevel * 12 + 8].Title;

			ChanceTextMale.Text = items[currentLevel * 12 + 9].Title;
			ChanceTextFemale.Text = items[currentLevel * 12 + 10].Title;

            if (chanceASkills[COOKING] != null)
            {
                ChoiceACooking.Value = chanceASkills[COOKING][currentLevel] / 100;
                ChoiceAMechanical.Value = chanceASkills[MECHANICAL][currentLevel] / 100;
                ChoiceABody.Value = chanceASkills[BODY][currentLevel] / 100;
                ChoiceACharisma.Value = chanceASkills[CHARISMA][currentLevel] / 100;
                ChoiceACreativity.Value = chanceASkills[CREATIVITY][currentLevel] / 100;
                ChoiceALogic.Value = chanceASkills[LOGIC][currentLevel] / 100;
                ChoiceACleaning.Value = chanceASkills[CLEANING][currentLevel] / 100;
            }
            else
            {
                ChoiceACooking.Enabled =
                ChoiceAMechanical.Enabled =
                ChoiceABody.Enabled =
                ChoiceACharisma.Enabled =
                ChoiceACreativity.Enabled =
                ChoiceALogic.Enabled =
                ChoiceACleaning.Enabled =
                false;
            }

            if (chanceBSkills[COOKING] != null)
            {
                ChoiceBCooking.Value = chanceBSkills[COOKING][currentLevel] / 100;
                ChoiceBMechanical.Value = chanceBSkills[MECHANICAL][currentLevel] / 100;
                ChoiceBBody.Value = chanceBSkills[BODY][currentLevel] / 100;
                ChoiceBCharisma.Value = chanceBSkills[CHARISMA][currentLevel] / 100;
                ChoiceBCreativity.Value = chanceBSkills[CREATIVITY][currentLevel] / 100;
                ChoiceBLogic.Value = chanceBSkills[LOGIC][currentLevel] / 100;
                ChoiceBCleaning.Value = chanceBSkills[CLEANING][currentLevel] / 100;
            }
            else
            {
                ChoiceBCooking.Enabled =
                ChoiceBMechanical.Enabled =
                ChoiceBBody.Enabled =
                ChoiceBCharisma.Enabled =
                ChoiceBCreativity.Enabled =
                ChoiceBLogic.Enabled =
                ChoiceBCleaning.Enabled =
                false;
            }

			ChanceCurrentLevel.Value = currentLevel;
			ChancePercent.Value = chanceChance[currentLevel];

            if (chanceAGood[COOKING] != null)
            {
                PassACooking.Value = chanceAGood[COOKING][currentLevel] / 100;
                PassAMechanical.Value = chanceAGood[MECHANICAL][currentLevel] / 100;
                PassABody.Value = chanceAGood[BODY][currentLevel] / 100;
                PassACharisma.Value = chanceAGood[CHARISMA][currentLevel] / 100;
                PassACreativity.Value = chanceAGood[CREATIVITY][currentLevel] / 100;
                PassALogic.Value = chanceAGood[LOGIC][currentLevel] / 100;
                PassACleaning.Value = chanceAGood[CLEANING][currentLevel] / 100;
            }
            else
            {
                PassACooking.Enabled =
                PassAMechanical.Enabled =
                PassABody.Enabled =
                PassACharisma.Enabled =
                PassACreativity.Enabled =
                PassALogic.Enabled =
                PassACleaning.Enabled =
                false;
            }
			PassAMoney.Value = chanceAGood[MONEY][currentLevel];
			PassAJobLevel.Value = chanceAGood[JOB][currentLevel];
			PassAMaleText.Text = items[currentLevel * 12 + 11].Title;
			PassAFemaleText.Text = items[currentLevel * 12 + 12].Title;

            if (chanceABad[COOKING] != null)
            {
                FailACooking.Value = chanceABad[COOKING][currentLevel] / 100;
                FailAMechanical.Value = chanceABad[MECHANICAL][currentLevel] / 100;
                FailABody.Value = chanceABad[BODY][currentLevel] / 100;
                FailACharisma.Value = chanceABad[CHARISMA][currentLevel] / 100;
                FailACreativity.Value = chanceABad[CREATIVITY][currentLevel] / 100;
                FailALogic.Value = chanceABad[LOGIC][currentLevel] / 100;
                FailACleaning.Value = chanceABad[CLEANING][currentLevel] / 100;
            }
            else
            {
                FailACooking.Enabled =
                FailAMechanical.Enabled =
                FailABody.Enabled =
                FailACharisma.Enabled =
                FailACreativity.Enabled =
                FailALogic.Enabled =
                FailACleaning.Enabled =
                false;
            }
			FailAMoney.Value = chanceABad[MONEY][currentLevel];
			FailAJobLevel.Value = chanceABad[JOB][currentLevel];
			FailAMaleText.Text = items[currentLevel * 12 + 13].Title;
			FailAFemaleText.Text = items[currentLevel * 12 + 14].Title;

            if (chanceBGood[COOKING] != null)
            {
                PassBCooking.Value = chanceBGood[COOKING][currentLevel] / 100;
                PassBMechanical.Value = chanceBGood[MECHANICAL][currentLevel] / 100;
                PassBBody.Value = chanceBGood[BODY][currentLevel] / 100;
                PassBCharisma.Value = chanceBGood[CHARISMA][currentLevel] / 100;
                PassBCreativity.Value = chanceBGood[CREATIVITY][currentLevel] / 100;
                PassBLogic.Value = chanceBGood[LOGIC][currentLevel] / 100;
                PassBCleaning.Value = chanceBGood[CLEANING][currentLevel] / 100;
            }
            else
            {
                PassBCooking.Enabled =
                PassBMechanical.Enabled =
                PassBBody.Enabled =
                PassBCharisma.Enabled =
                PassBCreativity.Enabled =
                PassBLogic.Enabled =
                PassBCleaning.Enabled =
                false;
            }
            PassBMoney.Value = chanceBGood[MONEY][currentLevel];
			PassBJobLevel.Value = chanceBGood[JOB][currentLevel];
			PassBMaleText.Text = items[currentLevel * 12 + 15].Title;
			PassBFemaleText.Text = items[currentLevel * 12 + 16].Title;

            if (chanceBBad[COOKING] != null)
            {
                FailBCooking.Value = chanceBBad[COOKING][currentLevel] / 100;
                FailBMechanical.Value = chanceBBad[MECHANICAL][currentLevel] / 100;
                FailBBody.Value = chanceBBad[BODY][currentLevel] / 100;
                FailBCharisma.Value = chanceBBad[CHARISMA][currentLevel] / 100;
                FailBCreativity.Value = chanceBBad[CREATIVITY][currentLevel] / 100;
                FailBLogic.Value = chanceBBad[LOGIC][currentLevel] / 100;
                FailBCleaning.Value = chanceBBad[CLEANING][currentLevel] / 100;
            }
			FailBMoney.Value = chanceBBad[MONEY][currentLevel];
			FailBJobLevel.Value = chanceBBad[JOB][currentLevel];
			FailBMaleText.Text = items[currentLevel * 12 + 17].Title;
			FailBFemaleText.Text = items[currentLevel * 12 + 18].Title;
		}

		private void levelChanged()
		{
            if (levelChanging) return;
			levelChanging = true;

			SimPe.PackedFiles.Wrapper.StrItemList items = jobTitles.LanguageItems(currentLanguage);

			// job details
			JobTitleMale.Text = items[currentLevel * 2 - 1].Title;
			JobDescMale.Text = items[currentLevel * 2].Title;
			JobTitleFemale.Text = items[currentLevel * 2 - 1 + femaleOffset].Title;
			JobDescFemale.Text = items[currentLevel * 2 + femaleOffset].Title;

			setOutfitFromGUID(outfitGUID[currentLevel * 2], outfitGUID[currentLevel * 2 + 1]);
			setVehicleFromGUID(vehicleGUID[currentLevel * 2], vehicleGUID[currentLevel * 2 + 1]);
	
			//hours & wages
			WorkStartHour.Value = startHour[currentLevel];
			WorkHoursWorked.Value = hoursWorked[currentLevel];
			WorkFinishHour.Value = (startHour[currentLevel] + hoursWorked[currentLevel]) % 24;

            if (wages != null)
            {
                WorkWages.Value = wages[currentLevel];
                nudWagesDog.Enabled = nudWagesCat.Enabled = false;
            }
            else
            {
                WorkWages.Enabled = false;
                nudWagesDog.Value = wagesDog[currentLevel];
                nudWagesCat.Value = wagesCat[currentLevel];
            }

			bool[] days = getDaysArray(daysWorked[currentLevel]);
			WorkSunday.Checked = days[SUNDAY];
			WorkMonday.Checked = days[MONDAY];
			WorkTuesday.Checked = days[TUESDAY];
			WorkWednesday.Checked = days[WEDNESDAY];
			WorkThursday.Checked = days[THURSDAY];
			WorkFriday.Checked = days[FRIDAY];
			WorkSaturday.Checked = days[SATURDAY];

			HungerHours.Value = hoursWorked[currentLevel];
			ThirstHours.Value = hoursWorked[currentLevel];
			ComfortHours.Value = hoursWorked[currentLevel];
			HygieneHours.Value = hoursWorked[currentLevel];
			BladderHours.Value = hoursWorked[currentLevel];
			EnergyHours.Value = hoursWorked[currentLevel];
			FunHours.Value = hoursWorked[currentLevel];
			PublicHours.Value = hoursWorked[currentLevel];
			FamilyHours.Value = hoursWorked[currentLevel];
			EnvironmentHours.Value = hoursWorked[currentLevel];

			WorkHunger.Value = motiveDeltas[HUNGER][currentLevel];
			WorkThirst.Value = motiveDeltas[THIRST][currentLevel];
			WorkComfort.Value = motiveDeltas[COMFORT][currentLevel];
			WorkHygiene.Value = motiveDeltas[HYGIENE][currentLevel];
			WorkBladder.Value = motiveDeltas[BLADDER][currentLevel];
			WorkEnergy.Value = motiveDeltas[ENERGY][currentLevel];
			WorkFun.Value = motiveDeltas[FUN][currentLevel];
			WorkPublic.Value = motiveDeltas[PUBLIC][currentLevel];
			WorkFamily.Value = motiveDeltas[FAMILY][currentLevel];
			WorkEnvironment.Value = motiveDeltas[ENVIRONMENT][currentLevel];

			HungerTotal.Value = motiveDeltas[HUNGER][currentLevel] * hoursWorked[currentLevel];
			ThirstTotal.Value = motiveDeltas[THIRST][currentLevel] * hoursWorked[currentLevel];
			ComfortTotal.Value = motiveDeltas[COMFORT][currentLevel] * hoursWorked[currentLevel];
			HygieneTotal.Value = motiveDeltas[HYGIENE][currentLevel] * hoursWorked[currentLevel];
			BladderTotal.Value = motiveDeltas[BLADDER][currentLevel] * hoursWorked[currentLevel];
			EnergyTotal.Value = motiveDeltas[ENERGY][currentLevel] * hoursWorked[currentLevel];
			FunTotal.Value = motiveDeltas[FUN][currentLevel] * hoursWorked[currentLevel];
			PublicTotal.Value = motiveDeltas[PUBLIC][currentLevel] * hoursWorked[currentLevel];
			FamilyTotal.Value = motiveDeltas[FAMILY][currentLevel] * hoursWorked[currentLevel];
			EnvironmentTotal.Value = motiveDeltas[ENVIRONMENT][currentLevel] * hoursWorked[currentLevel];

			//promotion
            if (skillReq[BODY] != null) // The first two are something else for Pets
            {
                PromoCooking.Value = skillReq[COOKING][currentLevel] / 100;
                PromoMechanical.Value = skillReq[MECHANICAL][currentLevel] / 100;
                PromoBody.Value = skillReq[BODY][currentLevel] / 100;
                PromoCharisma.Value = skillReq[CHARISMA][currentLevel] / 100;
                PromoCreativity.Value = skillReq[CREATIVITY][currentLevel] / 100;
                PromoLogic.Value = skillReq[LOGIC][currentLevel] / 100;
                PromoCleaning.Value = skillReq[CLEANING][currentLevel] / 100;
                nudPromoTricks.Enabled = false;
            }
            else
            {
                PromoCooking.Enabled =
                PromoMechanical.Enabled =
                PromoBody.Enabled =
                PromoCharisma.Enabled =
                PromoCreativity.Enabled =
                PromoLogic.Enabled =
                PromoCleaning.Enabled =
                false;
                nudPromoTricks.Value = tricks[currentLevel];
            }

			PromoFriends.Value = friends[currentLevel];

			JobDetailsBox.Text = "Current Level: " + currentLevel;
			HoursWagesBox.Text = "Current Level: " + currentLevel;
			PromoBox.Text = "Current Level: " + currentLevel;

			PassAJobLevel.Maximum = noLevels - currentLevel;
			FailAJobLevel.Maximum = noLevels - currentLevel;
			PassBJobLevel.Maximum = noLevels - currentLevel;
			FailBJobLevel.Maximum = noLevels - currentLevel;

			PassAJobLevel.Minimum = -currentLevel;
			FailAJobLevel.Minimum = -currentLevel;
			PassBJobLevel.Minimum = -currentLevel;
			FailBJobLevel.Minimum = -currentLevel;

			//chance cards
			fillChanceCards();

			levelChanging = false;
		}
		private void noLevelsChanged(ushort l)
		{
			noLevels = l;
			femaleOffset = (ushort)(2 * noLevels);
			CareerLvls.Value = noLevels;

			ChanceCurrentLevel.Maximum = noLevels;
			PassAJobLevel.Maximum = noLevels - currentLevel;
			FailAJobLevel.Maximum = noLevels - currentLevel;
			PassBJobLevel.Maximum = noLevels - currentLevel;
			FailBJobLevel.Maximum = noLevels - currentLevel;

			menuItem7.Enabled = (noLevels < 100);
			menuItem8.Enabled = (noLevels > 1);

			fillJobDetails();
			fillHoursAndWages();
			fillPromotionDetails();
		}
		private bool[] getDaysArray(short val)
		{
			bool[] days = new bool[7];
			int newval = val;
			if (val < 0)
				newval += 65536;
			days[MONDAY] = (newval % 2) == 1;
			newval /= 2;
			days[TUESDAY] = (newval % 2) == 1;
			newval /= 2;
			days[WEDNESDAY] = (newval % 2) == 1;
			newval /= 2;
			days[THURSDAY] = (newval % 2) == 1;
			newval /= 2;
			days[FRIDAY] = (newval % 2) == 1;
			newval /= 2;
			days[SATURDAY] = (newval % 2) == 1;
			newval /= 2;
			days[SUNDAY] = (newval % 2) == 1;
            
			return days;
		}
		private string getOutfitTextFromGUID(short val1, short val2)
		{
			uint guid = ((uint)((ushort)val2) * 65536) + ((ushort)val1);
			int index = 0;

			while (index < outfitGuids.Length)
			{
				if (outfitGuids[index] == guid)
					break;
				index++;
			}
			return outfitStrings[index];
		}

		private string getVehicleTextFromGUID(short val1, short val2)
		{
			uint guid = ((uint)((ushort)val2) * 65536) + ((ushort)val1);
			int index = 0;

			while (index < vehicleGuids.Length)
			{
				if (vehicleGuids[index] == guid)
					break;
				index++;
			}
			return vehicleStrings[index];
		}

		private void setRewardFromGUID(byte val1, byte val2, byte val3, byte val4)
		{
			uint guid = ((uint)val4 * 256) + val3;
			guid = ((uint)guid * 256) + val2;
			guid = ((uint)guid * 256) + val1;
			int index = 0;

			if (hasReward)
				while (index < rewardGuids.Length)
				{
					if (rewardGuids[index] == guid)
						break;
					index++;
				}
			else
				while (index < adultGuids.Length)
				{
					if (adultGuids[index] == guid)
						break;
					index++;
				}

			CareerReward.SelectedIndex = index;
		}

		private void setOutfitFromGUID(short val1, short val2)
		{
			uint guid = ((uint)((ushort)val2) * 65536) + ((ushort)val1);
			int index = 0;

			while (index < outfitGuids.Length)
			{
				if (outfitGuids[index] == guid)
					break;
				index++;
			}
			Outfit.SelectedIndex = index;
		}

		private void setVehicleFromGUID(short val1, short val2)
		{
			uint guid = ((uint)((ushort)val2) * 65536) + ((ushort)val1);
			int index = 0;

			while (index < vehicleGuids.Length)
			{
				if (vehicleGuids[index] == guid)
					break;
				index++;
			}
			Vehicle.SelectedIndex = index;
		}

		private Bcon getBcon(uint instance)
		{
			Interfaces.Files.IPackedFileDescriptor pfd = package.FindFile(0x42434F4E, 0, groupId, instance);
            if (pfd == null) return null;

			Bcon bcon = new Bcon();
			bcon.ProcessData(pfd, package);
			return bcon;
		}
		
		private SimPe.PackedFiles.Wrapper.Str getStr(uint instance)
		{
			Interfaces.Files.IPackedFileDescriptor pfd  = package.FindFile(0x53545223, 0, groupId, instance);
            if (pfd == null) return null;

            SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
			str.ProcessData(pfd, package);
			return str;
		}

		private void loadFiles()
		{
			Interfaces.Files.IPackedFileDescriptor[] ctss  = package.FindFiles(Data.MetaData.CTSS_FILE);
			groupId = ctss[0].Group;

			catalogueDesc = new SimPe.PackedFiles.Wrapper.Str();
			catalogueDesc.ProcessData(ctss[0], package);
			jobTitles = getStr(0x0093);

			vehicleGUID = getBcon(0x100C);
			outfitGUID = getBcon(0x1055);

			startHour  = getBcon(0x1001);
			hoursWorked = getBcon(0x1002);
			daysWorked = getBcon(0x101A);

			skillReq = new Bcon[8]; // not pets
			skillReq[COOKING] = getBcon(0x1004);
			skillReq[MECHANICAL] = getBcon(0x1005);
			skillReq[BODY] = getBcon(0x1006);
			skillReq[CHARISMA] = getBcon(0x1007);
			skillReq[CREATIVITY] = getBcon(0x1008);
			skillReq[LOGIC] = getBcon(0x1009);
			skillReq[GARDENING] = getBcon(0x100A);
			skillReq[CLEANING] = getBcon(0x100B);

            if (skillReq[2] != null)
            {
                wages = getBcon(0x1000);
                tricks = wagesDog = wagesCat = null;
            }
            else
            {
                wagesDog = getBcon(0x1000);
                wagesCat = getBcon(0x1005);
                tricks = getBcon(0x1004);
                wages = null;
            }

			friends = getBcon(0x1003);

			motiveDeltas = new Bcon[11];
			motiveDeltas[HUNGER] = getBcon(0x100E);
			motiveDeltas[THIRST] = getBcon(0x100F);
			motiveDeltas[COMFORT] = getBcon(0x1010);
			motiveDeltas[HYGIENE] = getBcon(0x1011);
			motiveDeltas[BLADDER] = getBcon(0x1012);
			motiveDeltas[ENERGY] = getBcon(0x1013);
			motiveDeltas[FUN] = getBcon(0x1014);
			motiveDeltas[PUBLIC] = getBcon(0x1015);
			motiveDeltas[FAMILY] = getBcon(0x1016);
			motiveDeltas[ENVIRONMENT] = getBcon(0x1017);
			motiveDeltas[MENTAL] = getBcon(0x1018);

			tuning = getBcon(0x1019);

			chanceCardsText = getStr(0x012D);

            chanceASkills = new Bcon[8]; // not pets
			chanceASkills[COOKING] = getBcon(0x101C);
			chanceASkills[MECHANICAL] = getBcon(0x101D);
			chanceASkills[BODY] = getBcon(0x101E);
			chanceASkills[CHARISMA] = getBcon(0x101F);
			chanceASkills[CREATIVITY] = getBcon(0x1020);
			chanceASkills[LOGIC] = getBcon(0x1021);
			chanceASkills[GARDENING] = getBcon(0x1022);
			chanceASkills[CLEANING] = getBcon(0x1023);

            chanceAGood = new Bcon[10]; // not pets
			chanceAGood[COOKING] = getBcon(0x102E);
			chanceAGood[MECHANICAL] = getBcon(0x102F);
			chanceAGood[BODY] = getBcon(0x1030);
			chanceAGood[CHARISMA] = getBcon(0x1031);
			chanceAGood[CREATIVITY] = getBcon(0x1032);
			chanceAGood[LOGIC] = getBcon(0x1033);
			chanceAGood[GARDENING] = getBcon(0x1034);
			chanceAGood[CLEANING] = getBcon(0x1035);

            // these for pets
			chanceAGood[MONEY] = getBcon(0x102C);
			chanceAGood[JOB] = getBcon(0x102D);

            chanceABad = new Bcon[10]; // not pets
			chanceABad[COOKING] = getBcon(0x1038);
			chanceABad[MECHANICAL] = getBcon(0x1039);
			chanceABad[BODY] = getBcon(0x103A);
			chanceABad[CHARISMA] = getBcon(0x103B);
			chanceABad[CREATIVITY] = getBcon(0x103C);
			chanceABad[LOGIC] = getBcon(0x103D);
			chanceABad[GARDENING] = getBcon(0x103E);
			chanceABad[CLEANING] = getBcon(0x103F);

            // these for pets
			chanceABad[MONEY] = getBcon(0x1036);
			chanceABad[JOB] = getBcon(0x1037);

            chanceBSkills = new Bcon[8]; // not pets
			chanceBSkills[COOKING] = getBcon(0x1024);
			chanceBSkills[MECHANICAL] = getBcon(0x1025);
			chanceBSkills[BODY] = getBcon(0x1026);
			chanceBSkills[CHARISMA] = getBcon(0x1027);
			chanceBSkills[CREATIVITY] = getBcon(0x1028);
			chanceBSkills[LOGIC] = getBcon(0x1029);
			chanceBSkills[GARDENING] = getBcon(0x102A);
			chanceBSkills[CLEANING] = getBcon(0x102B);

			chanceBGood = new Bcon[10];
			chanceBGood[COOKING] = getBcon(0x1042);
			chanceBGood[MECHANICAL] = getBcon(0x1043);
			chanceBGood[BODY] = getBcon(0x1044);
			chanceBGood[CHARISMA] = getBcon(0x1045);
			chanceBGood[CREATIVITY] = getBcon(0x1046);
			chanceBGood[LOGIC] = getBcon(0x1047);
			chanceBGood[GARDENING] = getBcon(0x1048);
			chanceBGood[CLEANING] = getBcon(0x1049);

            // these for pets
			chanceBGood[MONEY] = getBcon(0x1040);
			chanceBGood[JOB] = getBcon(0x1041);

			chanceBBad = new Bcon[10];
			chanceBBad[COOKING] = getBcon(0x104C);
			chanceBBad[MECHANICAL] = getBcon(0x104D);
			chanceBBad[BODY] = getBcon(0x104E);
			chanceBBad[CHARISMA] = getBcon(0x104F);
			chanceBBad[CREATIVITY] = getBcon(0x1050);
			chanceBBad[LOGIC] = getBcon(0x1051);
			chanceBBad[GARDENING] = getBcon(0x1052);
			chanceBBad[CLEANING] = getBcon(0x1053);

            // these for pets
			chanceBBad[MONEY] = getBcon(0x104A);
			chanceBBad[JOB] = getBcon(0x104B);

			chanceChance = getBcon(0x101B);

			lifeScore = getBcon(0x100D); // not pets
			PTO = getBcon(0x1054);

			Interfaces.Files.IPackedFileDescriptor pfd = package.FindFile(0x42484156, 0, groupId, 0x1001);
			BHavReward = new Bhav();
			BHavReward.ProcessData(pfd, package);
		}

		private void saveFiles()
		{
			catalogueDesc.SynchronizeUserData();
			jobTitles.SynchronizeUserData();

			vehicleGUID.SynchronizeUserData();
			outfitGUID.SynchronizeUserData();

			startHour.SynchronizeUserData();
			hoursWorked.SynchronizeUserData();
			daysWorked.SynchronizeUserData();

            if (wages != null)
            {
                wages.SynchronizeUserData();
            }
            else
            {
                wagesDog.SynchronizeUserData();
                wagesCat.SynchronizeUserData();
                tricks.SynchronizeUserData();
            }

            if (chanceASkills[0] != null)
            {
                for (int i = 0; i < 8; i++)
                {
                    skillReq[i].SynchronizeUserData();
                    chanceASkills[i].SynchronizeUserData();
                    chanceBSkills[i].SynchronizeUserData();
                }
            }

			friends.SynchronizeUserData();

			for (int i = 0; i < 11; i++)
				motiveDeltas[i].SynchronizeUserData();

			tuning.SynchronizeUserData();

			chanceCardsText.SynchronizeUserData();

            if (chanceAGood[0] != null)
            {
                for (int i = 0; i < 8; i++)
                {
                    chanceAGood[i].SynchronizeUserData();
                    chanceABad[i].SynchronizeUserData();
                    chanceBGood[i].SynchronizeUserData();
                    chanceBBad[i].SynchronizeUserData();
                }
            }
            for (int i = 8; i < 10; i++)
            {
                chanceAGood[i].SynchronizeUserData();
                chanceABad[i].SynchronizeUserData();
                chanceBGood[i].SynchronizeUserData();
                chanceBBad[i].SynchronizeUserData();
            }

			chanceChance.SynchronizeUserData();
            if (lifeScore != null)
                lifeScore.SynchronizeUserData();
			PTO.SynchronizeUserData();

			//if (hasReward)
			BHavReward.SynchronizeUserData();
		}
		private void PromoList_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			System.Windows.Forms.ListView.SelectedIndexCollection indices = ((System.Windows.Forms.ListView)sender).SelectedIndices;
			if ((indices.Count > 0) && (indices[0] < noLevels))
			{
				getChanceCardValues();
				currentLevel = (ushort)(indices[0] + 1);
				levelChanged();
			}
		}

		private void HoursWagesList_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			System.Windows.Forms.ListView.SelectedIndexCollection indices = ((System.Windows.Forms.ListView)sender).SelectedIndices;
			if ((indices.Count > 0) && (indices[0] < noLevels))
			{
				getChanceCardValues();
				currentLevel = (ushort)(indices[0] + 1);
				levelChanged();
			}
		}

		private void JobDetailList_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			System.Windows.Forms.ListView.SelectedIndexCollection indices = ((System.Windows.Forms.ListView)sender).SelectedIndices;
			if ((indices.Count > 0) && (indices[0] < noLevels))
			{
				getChanceCardValues();
				currentLevel = (ushort)(indices[0] + 1);
				levelChanged();
			}
		}

		private void ChanceCurrentLevel_ValueChanged(object sender, System.EventArgs e)
		{
			if (!levelChanging)
			{
				getChanceCardValues();
				currentLevel = (ushort)((System.Windows.Forms.NumericUpDown)sender).Value;
				levelChanged();
			}
		}
		private void MaleToFemale(System.Windows.Forms.TextBox male, System.Windows.Forms.TextBox female)
		{
			//todo - auto pronoun scaning
			female.Text = male.Text;
		}
		private void JobDetailsCopy_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			MaleToFemale(JobDescMale, JobDescFemale);
		}

		private void ChanceCopy_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			MaleToFemale(ChanceTextMale, ChanceTextFemale);
		}

		private void FailBCopy_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			MaleToFemale(FailBMaleText, FailBFemaleText);
		}

		private void PassBCopy_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			MaleToFemale(PassBMaleText, PassBFemaleText);
		}

		private void FailACopy_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			MaleToFemale(FailAMaleText, FailAFemaleText);
		}

		private void PassACopy_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			MaleToFemale(PassAMaleText, PassAFemaleText);
		}

		private void CareerReward_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			int index = ((System.Windows.Forms.ComboBox)sender).SelectedIndex;
			uint temp;

			if (index == CareerReward.Items.Count - 1)
				return;

			if (hasReward)
				temp = rewardGuids[index];
			else
				temp = adultGuids[index];

			byte val1 = (byte)(temp % 256);
			temp /= 256;
			byte val2 = (byte)(temp % 256);
			temp /= 256;
			byte val3 = (byte)(temp % 256);
			byte val4 = (byte)(temp / 256);

			if (hasReward)
			{
				BHavReward[2].Operands[5] = val1;
				BHavReward[2].Operands[6] = val2;
				BHavReward[2].Operands[7] = val3;
				BHavReward[2].Reserved1[0] = val4;
			}
			else
			{
				BHavReward[1].Operands[0] = val1;
				BHavReward[1].Operands[1] = val2;
				BHavReward[1].Operands[2] = val3;
				BHavReward[1].Operands[3] = val4;
			}
		}

		private void Outfit_SelectedIndexChanged(object sender, System.EventArgs e)
		{
            if (internalchg) return;

			int index = ((System.Windows.Forms.ComboBox)sender).SelectedIndex;
			ListViewItem item = JobDetailList.Items[currentLevel - 1];
			item.SubItems[3].Text = outfitStrings[index];
			if (index == outfitGuids.Length) // unknown
				return;

			ushort val1 = (ushort)(outfitGuids[index] % 65536);
			ushort val2 = (ushort)(outfitGuids[index] / 65536);

			outfitGUID[currentLevel * 2] = (short)val1;
			outfitGUID[currentLevel * 2 + 1] = (short)val2;
		}

		private void Vehicle_SelectedIndexChanged(object sender, System.EventArgs e)
		{
            if (internalchg) return;

			int index = ((System.Windows.Forms.ComboBox)sender).SelectedIndex;
			ListViewItem item = JobDetailList.Items[currentLevel - 1];
			item.SubItems[4].Text = vehicleStrings[index];
			if (index == vehicleGuids.Length) // unknown
				return;

			ushort val1 = (ushort)(vehicleGuids[index] % 65536);
			ushort val2 = (ushort)(vehicleGuids[index] / 65536);

			vehicleGUID[currentLevel * 2] = (short)val1;
			vehicleGUID[currentLevel * 2 + 1] = (short)val2;
		}

		private void JobDescMale_TextChanged(object sender, System.EventArgs e)
		{
			string text = ((System.Windows.Forms.TextBox)sender).Text;
			ListViewItem item = JobDetailList.Items[currentLevel - 1];
			item.SubItems[2].Text = text;
			SimPe.PackedFiles.Wrapper.StrItemList items = jobTitles.LanguageItems(currentLanguage);
			items[currentLevel * 2].Title = text;
		}

		private void JobTitleMale_TextChanged(object sender, System.EventArgs e)
		{
			string text = ((System.Windows.Forms.TextBox)sender).Text;
			ListViewItem item = JobDetailList.Items[currentLevel - 1];
			item.SubItems[1].Text = text;
			SimPe.PackedFiles.Wrapper.StrItemList items = jobTitles.LanguageItems(currentLanguage);
			items[currentLevel * 2 - 1].Title = text;
		}

		private void JobTitleFemale_TextChanged(object sender, System.EventArgs e)
		{
			string text = ((System.Windows.Forms.TextBox)sender).Text;
			SimPe.PackedFiles.Wrapper.StrItemList items = jobTitles.LanguageItems(currentLanguage);
			items[currentLevel * 2 - 1 + femaleOffset].Title = text;
		}

		private void JobDescFemale_TextChanged(object sender, System.EventArgs e)
		{
			string text = ((System.Windows.Forms.TextBox)sender).Text;
			SimPe.PackedFiles.Wrapper.StrItemList items = jobTitles.LanguageItems(currentLanguage);
			items[currentLevel * 2  + femaleOffset].Title = text;
		}

		private void CareerTitle_TextChanged(object sender, System.EventArgs e)
		{
			string text = ((System.Windows.Forms.TextBox)sender).Text;
			SimPe.PackedFiles.Wrapper.StrItemList items = catalogueDesc.LanguageItems(currentLanguage);
			items[0].Title = text;
		}

		private void Work_ValueChanged(object sender, System.EventArgs e)
		{
			if (!levelChanging)
				WorkChanged();
		}

		private void Work_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			WorkChanged();
		}
		private void WorkChanged()
		{
			short val = (short)WorkStartHour.Value;
			startHour[currentLevel] = val;

			ListViewItem item = HoursWagesList.Items[currentLevel - 1];
			item.SubItems[1].Text = ""+val;

			val = (short)WorkHoursWorked.Value;
			hoursWorked[currentLevel] = val;
			WorkFinishHour.Value = (startHour[currentLevel] + val) % 24;

			item.SubItems[2].Text = ""+val;
			item.SubItems[3].Text = ""+(startHour[currentLevel] + val) % 24;

			HungerHours.Value = val;
			ThirstHours.Value = val;
			ComfortHours.Value = val;
			HygieneHours.Value = val;
			BladderHours.Value = val;
			EnergyHours.Value = val;
			FunHours.Value = val;
			PublicHours.Value = val;
			FamilyHours.Value = val;
			EnvironmentHours.Value = val;

			HungerTotal.Value = motiveDeltas[HUNGER][currentLevel] * val;
			ThirstTotal.Value = motiveDeltas[THIRST][currentLevel] * val;
			ComfortTotal.Value = motiveDeltas[COMFORT][currentLevel] * val;
			HygieneTotal.Value = motiveDeltas[HYGIENE][currentLevel] * val;
			BladderTotal.Value = motiveDeltas[BLADDER][currentLevel] * val;
			EnergyTotal.Value = motiveDeltas[ENERGY][currentLevel] * val;
			FunTotal.Value = motiveDeltas[FUN][currentLevel] * val;
			PublicTotal.Value = motiveDeltas[PUBLIC][currentLevel] * val;
			FamilyTotal.Value = motiveDeltas[FAMILY][currentLevel] * val;
			EnvironmentTotal.Value = motiveDeltas[ENVIRONMENT][currentLevel] * val;

            if (wages != null)
            {
                val = (short)WorkWages.Value;
                wages[currentLevel] = val;
            }
            else
            {
                wagesDog[currentLevel] = (short)nudWagesDog.Value;
                wagesCat[currentLevel] = (short)nudWagesCat.Value;
            }

			item.SubItems[4].Text = ""+val;

			val = (short)WorkHunger.Value;
			motiveDeltas[HUNGER][currentLevel] = val;
			HungerTotal.Value = val * hoursWorked[currentLevel];

			val = (short)WorkThirst.Value;
			motiveDeltas[THIRST][currentLevel] = val;
			ThirstTotal.Value = val * hoursWorked[currentLevel];

			val = (short)WorkComfort.Value;
			motiveDeltas[COMFORT][currentLevel] = val;
			ComfortTotal.Value = val * hoursWorked[currentLevel];

			val = (short)WorkHygiene.Value;
			motiveDeltas[HYGIENE][currentLevel] = val;
			HygieneTotal.Value = val * hoursWorked[currentLevel];

			val = (short)WorkBladder.Value;
			motiveDeltas[BLADDER][currentLevel] = val;
			BladderTotal.Value = val * hoursWorked[currentLevel];

			val = (short)WorkEnergy.Value;
			motiveDeltas[ENERGY][currentLevel] = val;
			EnergyTotal.Value = val * hoursWorked[currentLevel];

			val = (short)WorkFun.Value;
			motiveDeltas[FUN][currentLevel] = val;
			FunTotal.Value = val * hoursWorked[currentLevel];

			val = (short)WorkPublic.Value;
			motiveDeltas[PUBLIC][currentLevel] = val;
			PublicTotal.Value = val * hoursWorked[currentLevel];

			val = (short)WorkFamily.Value;
			motiveDeltas[FAMILY][currentLevel] = val;
			FamilyTotal.Value = val * hoursWorked[currentLevel];

			val = (short)WorkEnvironment.Value;
			motiveDeltas[ENVIRONMENT][currentLevel] = val;
			EnvironmentTotal.Value = val * hoursWorked[currentLevel];
		}

		private void Workday_CheckedChanged(object sender, System.EventArgs e)
		{
			if (!levelChanging)
			{
				short val = 0;
				if (WorkSunday.Checked)
					val += 64;
				if (WorkMonday.Checked)
					val += 1;
				if (WorkTuesday.Checked)
					val += 2;
				if (WorkWednesday.Checked)
					val += 4;
				if (WorkThursday.Checked)
					val += 8;
				if (WorkFriday.Checked)
					val += 16;
				if (WorkSaturday.Checked)
					val += 32;
				daysWorked[currentLevel] = val;

				ListViewItem item = HoursWagesList.Items[currentLevel - 1];
				item.SubItems[5].Text = ""+WorkSunday.Checked;
				item.SubItems[6].Text = ""+WorkMonday.Checked;
				item.SubItems[7].Text = ""+WorkTuesday.Checked;
				item.SubItems[8].Text = ""+WorkWednesday.Checked;
				item.SubItems[9].Text = ""+WorkThursday.Checked;
				item.SubItems[10].Text = ""+WorkFriday.Checked;
				item.SubItems[11].Text = ""+WorkSaturday.Checked;
			}
		}

		private void Promo_ValueChanged(object sender, System.EventArgs e)
		{
            if (levelChanging) return;

            ArrayList foo = new ArrayList(new NumericUpDown[] {
                PromoCooking, PromoMechanical, PromoBody, PromoCharisma,
                PromoCreativity, PromoLogic, PromoCleaning,
                PromoFriends,
            });
            int i = foo.IndexOf((NumericUpDown)sender);
            if (i == -1) return; // crash!
            ListViewItem item = PromoList.Items[currentLevel - 1];

            short val = (short)((NumericUpDown)sender).Value;
            item.SubItems[i + 1].Text = "" + val;
            if (i < 7)
                skillReq[i][currentLevel] = (short)(val * 100);
            else if (i == 8)
                friends[currentLevel] = val;
            else if (i == 9)
                tricks[currentLevel] = val;
        }
		private void Promo_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
            Promo_ValueChanged(sender, e);		
		}
		private void getChanceCardValues()
		{
			SimPe.PackedFiles.Wrapper.StrItemList items = chanceCardsText.LanguageItems(currentLanguage);
			chanceChance[currentLevel] = (short)ChancePercent.Value;

			items[currentLevel * 12 + 7].Title = ChoiceA.Text;
            if (chanceASkills[COOKING] != null)
            {
                chanceASkills[COOKING][currentLevel] = (short)(ChoiceACooking.Value * 100);
                chanceASkills[MECHANICAL][currentLevel] = (short)(ChoiceAMechanical.Value * 100);
                chanceASkills[CHARISMA][currentLevel] = (short)(ChoiceACharisma.Value * 100);
                chanceASkills[BODY][currentLevel] = (short)(ChoiceABody.Value * 100);
                chanceASkills[CREATIVITY][currentLevel] = (short)(ChoiceACreativity.Value * 100);
                chanceASkills[LOGIC][currentLevel] = (short)(ChoiceALogic.Value * 100);
                chanceASkills[CLEANING][currentLevel] = (short)(ChoiceACleaning.Value * 100);
            }

			items[currentLevel * 12 + 8].Title = ChoiceB.Text;
            if (chanceBSkills[COOKING] != null)
            {
                chanceBSkills[COOKING][currentLevel] = (short)(ChoiceBCooking.Value * 100);
                chanceBSkills[MECHANICAL][currentLevel] = (short)(ChoiceBMechanical.Value * 100);
                chanceBSkills[CHARISMA][currentLevel] = (short)(ChoiceBCharisma.Value * 100);
                chanceBSkills[BODY][currentLevel] = (short)(ChoiceBBody.Value * 100);
                chanceBSkills[CREATIVITY][currentLevel] = (short)(ChoiceBCreativity.Value * 100);
                chanceBSkills[LOGIC][currentLevel] = (short)(ChoiceBLogic.Value * 100);
                chanceBSkills[CLEANING][currentLevel] = (short)(ChoiceBCleaning.Value * 100);
            }

			items[currentLevel * 12 + 9].Title = ChanceTextMale.Text;
			items[currentLevel * 12 + 10].Title = ChanceTextFemale.Text;

            if (chanceAGood[COOKING] != null)
            {
                chanceAGood[COOKING][currentLevel] = (short)(PassACooking.Value * 100);
                chanceAGood[MECHANICAL][currentLevel] = (short)(PassAMechanical.Value * 100);
                chanceAGood[CHARISMA][currentLevel] = (short)(PassACharisma.Value * 100);
                chanceAGood[BODY][currentLevel] = (short)(PassABody.Value * 100);
                chanceAGood[CREATIVITY][currentLevel] = (short)(PassACreativity.Value * 100);
                chanceAGood[LOGIC][currentLevel] = (short)(PassALogic.Value * 100);
                chanceAGood[CLEANING][currentLevel] = (short)(PassACleaning.Value * 100);
            }
			chanceAGood[MONEY][currentLevel] = (short)PassAMoney.Value;
			chanceAGood[JOB][currentLevel] = (short)PassAJobLevel.Value;
			items[currentLevel * 12 + 11].Title = PassAMaleText.Text;
			items[currentLevel * 12 + 12].Title = PassAFemaleText.Text;

            if (chanceABad[COOKING] != null)
            {
                chanceABad[COOKING][currentLevel] = (short)(FailACooking.Value * 100);
                chanceABad[MECHANICAL][currentLevel] = (short)(FailAMechanical.Value * 100);
                chanceABad[CHARISMA][currentLevel] = (short)(FailACharisma.Value * 100);
                chanceABad[BODY][currentLevel] = (short)(FailABody.Value * 100);
                chanceABad[CREATIVITY][currentLevel] = (short)(FailACreativity.Value * 100);
                chanceABad[LOGIC][currentLevel] = (short)(FailALogic.Value * 100);
                chanceABad[CLEANING][currentLevel] = (short)(FailACleaning.Value * 100);
            }
			chanceABad[MONEY][currentLevel] = (short)FailAMoney.Value;
			chanceABad[JOB][currentLevel] = (short)FailAJobLevel.Value;
			items[currentLevel * 12 + 13].Title = FailAMaleText.Text;
			items[currentLevel * 12 + 14].Title = FailAFemaleText.Text;

            if (chanceBGood[COOKING] != null)
            {
                chanceBGood[COOKING][currentLevel] = (short)(PassBCooking.Value * 100);
                chanceBGood[MECHANICAL][currentLevel] = (short)(PassBMechanical.Value * 100);
                chanceBGood[CHARISMA][currentLevel] = (short)(PassBCharisma.Value * 100);
                chanceBGood[BODY][currentLevel] = (short)(PassBBody.Value * 100);
                chanceBGood[CREATIVITY][currentLevel] = (short)(PassBCreativity.Value * 100);
                chanceBGood[LOGIC][currentLevel] = (short)(PassBLogic.Value * 100);
                chanceBGood[CLEANING][currentLevel] = (short)(PassBCleaning.Value * 100);
            }
			chanceBGood[MONEY][currentLevel] = (short)PassBMoney.Value;
			chanceBGood[JOB][currentLevel] = (short)PassBJobLevel.Value;
			items[currentLevel * 12 + 15].Title = PassBMaleText.Text;
			items[currentLevel * 12 + 16].Title = PassBFemaleText.Text;

            if (chanceBBad[COOKING] != null)
            {
                chanceBBad[COOKING][currentLevel] = (short)(FailBCooking.Value * 100);
                chanceBBad[MECHANICAL][currentLevel] = (short)(FailBMechanical.Value * 100);
                chanceBBad[CHARISMA][currentLevel] = (short)(FailBCharisma.Value * 100);
                chanceBBad[BODY][currentLevel] = (short)(FailBBody.Value * 100);
                chanceBBad[CREATIVITY][currentLevel] = (short)(FailBCreativity.Value * 100);
                chanceBBad[LOGIC][currentLevel] = (short)(FailBLogic.Value * 100);
                chanceBBad[CLEANING][currentLevel] = (short)(FailBCleaning.Value * 100);
            }
			chanceBBad[MONEY][currentLevel] = (short)FailBMoney.Value;
			chanceBBad[JOB][currentLevel] = (short)FailBJobLevel.Value;
			items[currentLevel * 12 + 17].Title = FailBMaleText.Text;
			items[currentLevel * 12 + 18].Title = FailBFemaleText.Text;
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			englishOnly = !englishOnly;
			((System.Windows.Forms.MenuItem)sender).Checked = englishOnly;
		}

		private void Language_SelectedIndexChanged(object sender, System.EventArgs e)
		{
            if (internalchg) return;

			levelChanged();
			getChanceCardValues();
			int index = ((System.Windows.Forms.ComboBox)sender).SelectedIndex;
			currentLanguage = new SimPe.PackedFiles.Wrapper.StrLanguage((byte)languageID[index]); 
			JobDetailList.Items.Clear();
			fillJobDetails();
			levelChanged();

			SimPe.PackedFiles.Wrapper.StrItemList items = catalogueDesc.LanguageItems(currentLanguage);
			CareerTitle.Text = items[0].Title;
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			ushort newNoLevels = (ushort)(noLevels + 1);

			tuning[0] = (short)newNoLevels;

			if (PTO.Count < newNoLevels + 1)
			{
                PTO.Add(15);                
				lifeScore.Add(0);

                startHour.Add(0);
                hoursWorked.Add(1);
                daysWorked.Add(0);
                if (wages != null)
                {
                    wages.Add(0);
                }
                else
                {
                    wagesDog.Add(0);
                    wagesCat.Add(0);
                    tricks.Add(0);
                }

				for (int i = 0; i < 8; i++)
				{
					skillReq[i].Add(0);
                    chanceASkills[i].Add(0);
                    chanceBSkills[i].Add(0); ;
				}

                friends.Add(0);

                for (int i = 0; i < 11; i++)
                    motiveDeltas[i].Add(0);

				for (int i = 0; i < 10; i++)
				{
                    chanceAGood[i].Add(0);
                    chanceABad[i].Add(0);
                    chanceBGood[i].Add(0);
                    chanceBBad[i].Add(0);
				}
                chanceChance.Add(0);

                outfitGUID.Add(0);
                outfitGUID.Add(0);
				unchecked
				{
                    vehicleGUID.Add((short)0xAE14);
					vehicleGUID .Add((short)0x0C85);
				}
			}

			for (int i = 0; i < jobTitles.Languages.Length; i++)
			{
				SimPe.PackedFiles.Wrapper.StrLanguage l = new SimPe.PackedFiles.Wrapper.StrLanguage(jobTitles.Languages[i].Id);
				for (int j = 0; j < 4; j++)
					jobTitles.Add(new SimPe.PackedFiles.Wrapper.StrToken(j, l, "", ""));
				if ((l.Id != 2) && (l.Id != 12) && (l.Id != 13))
				{
					SimPe.PackedFiles.Wrapper.StrItemList items = jobTitles.LanguageItems(l);
					for (int j = noLevels; j > 0; j--)
					{
						items[j * 2 + 1 + femaleOffset].Title = items[j * 2 - 1 + femaleOffset].Title;
						items[j * 2 + 2 + femaleOffset].Title = items[j * 2 + femaleOffset].Title;
					}
					items[1 + femaleOffset].Title = "";
					items[2 + femaleOffset].Title = "";
				}
			}

			SimPe.PackedFiles.Wrapper.StrLanguage us = new SimPe.PackedFiles.Wrapper.StrLanguage(1);
			SimPe.PackedFiles.Wrapper.StrItemList usitems = jobTitles.LanguageItems(us);
			usitems[newNoLevels * 2 - 1].Title = "New Male Job Title";
			usitems[newNoLevels * 2].Title = "New Male Job Desc";
			usitems[newNoLevels * 2 - 1 + femaleOffset + 2].Title = "New Female Job Title";
			usitems[newNoLevels * 2 + femaleOffset + 2].Title = "New Female Job Desc";

			for (int i = 0; i < chanceCardsText.Languages.Length; i++)
			{
				SimPe.PackedFiles.Wrapper.StrLanguage l = new SimPe.PackedFiles.Wrapper.StrLanguage(chanceCardsText.Languages[i].Id);
				for (int j = 0; j < 12; j++)
					chanceCardsText.Add(new SimPe.PackedFiles.Wrapper.StrToken(j, l, "", ""));
			}
			usitems = chanceCardsText.LanguageItems(us);

			usitems[newNoLevels * 12 + 7].Title = "Choice A";
			usitems[newNoLevels * 12 + 8].Title = "Choice B";
			usitems[newNoLevels * 12 + 9].Title = "Male Text";
			usitems[newNoLevels * 12 + 10].Title = "Female Text";
			usitems[newNoLevels * 12 + 11].Title = "Pass A Male";
			usitems[newNoLevels * 12 + 12].Title = "Pass A Female";
			usitems[newNoLevels * 12 + 13].Title = "Fail A Male";
			usitems[newNoLevels * 12 + 14].Title = "Fail A Female";
			usitems[newNoLevels * 12 + 15].Title = "Pass B Male";
			usitems[newNoLevels * 12 + 16].Title = "Pass B Female";
			usitems[newNoLevels * 12 + 17].Title = "Fail B Male";
			usitems[newNoLevels * 12 + 18].Title = "Fail B Female";

			noLevelsChanged(newNoLevels);
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			ushort newNoLevels = (ushort)(noLevels - 1);

			tuning[0] = (short)newNoLevels;

			if (PTO.Count > 11)
			{
				PTO.RemoveAt(noLevels); 
				lifeScore.RemoveAt(noLevels); 

				startHour.RemoveAt(noLevels); 
				hoursWorked.RemoveAt(noLevels); 
				daysWorked .RemoveAt(noLevels);
                if (wages != null)
                {
                    wages.RemoveAt(noLevels);
                }
                else
                {
                    wagesDog.RemoveAt(noLevels);
                    wagesCat.RemoveAt(noLevels);
                    tricks.RemoveAt(noLevels);
                }

				for (int i = 0; i < 8; i++)
				{
					skillReq[i].RemoveAt(noLevels); 
					chanceASkills[i].RemoveAt(noLevels); 
					chanceBSkills[i].RemoveAt(noLevels); 
				}

				friends.RemoveAt(noLevels); 

				for (int i = 0; i < 11; i++)
					motiveDeltas[i].RemoveAt(noLevels); 

				for (int i = 0; i < 10; i++)
				{
					chanceAGood[i].RemoveAt(noLevels); 
					chanceABad[i].RemoveAt(noLevels); 
					chanceBGood[i].RemoveAt(noLevels); 
					chanceBBad[i].RemoveAt(noLevels); 
				}
				chanceChance.RemoveAt(noLevels); 

				outfitGUID.RemoveAt(noLevels * 2); 
				outfitGUID.RemoveAt(noLevels * 2); 
				unchecked
				{
					vehicleGUID.RemoveAt(noLevels * 2); 
					vehicleGUID.RemoveAt(noLevels * 2); 
				}
			}

			for (int i = 0; i < jobTitles.Languages.Length; i++)
			{
				SimPe.PackedFiles.Wrapper.StrLanguage l = new SimPe.PackedFiles.Wrapper.StrLanguage(jobTitles.Languages[i].Id);
				SimPe.PackedFiles.Wrapper.StrItemList items = jobTitles.LanguageItems(l);
				if ((l.Id != 2) && (l.Id != 12) && (l.Id != 13))
				{
					for (int j = 0; j < noLevels; j++)
					{
						items[j * 2 - 1 + femaleOffset].Title = items[j * 2 + 1 + femaleOffset].Title;
						items[j * 2 + femaleOffset].Title = items[j * 2 + 2 + femaleOffset].Title;
					}
				}

				for (int j = 0; j < 4; j++)
					items.Remove(items[items.Length - 1]);
			}

			for (int i = 0; i < chanceCardsText.Languages.Length; i++)
			{
				SimPe.PackedFiles.Wrapper.StrLanguage l = new SimPe.PackedFiles.Wrapper.StrLanguage(chanceCardsText.Languages[i].Id);
				SimPe.PackedFiles.Wrapper.StrItemList items = chanceCardsText.LanguageItems(l);
				for (int j = 0; j < 12; j++)
					items.Remove(items[items.Length - 1]);
			}

			noLevelsChanged(newNoLevels);
		}
	}
}
