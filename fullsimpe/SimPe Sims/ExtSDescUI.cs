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
	public partial class ExtSDesc : 
		//System.Windows.Forms.UserControl 
		SimPe.Windows.Forms.WrapperBaseControl, IPackedFileUI
	{
		

		
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
            this.biEP6.Tag = pnVoyage;
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
            this.cbEp3Asgn.Enum = typeof(Wrapper.JobAssignment);            
		}		


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
                        if (pn == pnChar)
                        {
                            SetCharacterAttributesVisibility();                            
                        }
                        
                        pn.Visible = item.Checked;                        
					}
				}
			}

			mbiMax.Enabled = pnSkill.Visible || pnChar.Visible || pnInt.Visible || pnRel.Visible;
			this.miRand.Enabled = mbiMax.Enabled;
            this.miOpenSCOR.Enabled = (int)PathProvider.Global.Latest.Expansion >= (int)Expansions.Business;
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

            if ((SimPe.PathProvider.Global.EPInstalled >= 1) || (Helper.WindowsRegistry.HiddenMode))
            {
                this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Paranormal));
                this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.NaturalScientist));
                this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.ShowBiz));
                this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Artist));
            }

            if ((SimPe.PathProvider.Global.EPInstalled >= 8) || (Helper.WindowsRegistry.HiddenMode))
            {
                this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Adventurer));
                this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Education));
                this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Gamer));
                this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Journalism));
                this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Law));
                this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Music));
            }
			
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

            if ((SimPe.PathProvider.Global.EPInstalled >= 8) || (Helper.WindowsRegistry.HiddenMode))
            {
                this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.TeenElderAdventurer));
                this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.TeenElderEducation));
                this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.TeenElderGamer));
                this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.TeenElderJournalism));
                this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.TeenElderLaw));
                this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.TeenElderMusic));
            }

            if ((SimPe.PathProvider.Global.EPInstalled >= 6) || (Helper.WindowsRegistry.HiddenMode))
            {
                this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.PetSecurity));
                this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.PetService));
                this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.PetService));
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

            this.cbSpecies.ResourceManager = SimPe.Localization.Manager;
            this.cbSpecies.Enum = typeof(SimPe.PackedFiles.Wrapper.SdscNightlife.SpeciesType);
            this.cbSpecies.ResourceManager = SimPe.Localization.Manager;
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
                this.biEP6.Enabled = (int)Sdesc.Version >= (int)SimPe.PackedFiles.Wrapper.SDescVersions.Voyage;                 
				if (pnEP1.Visible && !biEP1.Enabled) this.SelectButton(biId);
				if (pnEP2.Visible && !biEP2.Enabled) this.SelectButton(biId);
                if (pnEP3.Visible && !biEP3.Enabled) this.SelectButton(biId);
                if (pnVoyage.Visible && !biEP6.Enabled) this.SelectButton(biId);

                
				if (biEP1.Enabled) RefreshEP1(Sdesc);
                if (biEP2.Enabled) RefreshEP2(Sdesc);
                else cbSpecies.SelectedValue = SimPe.PackedFiles.Wrapper.SdscNightlife.SpeciesType.Human;
				if (biEP3.Enabled) RefreshEP3(Sdesc);
                RefreshEP4(Sdesc);
                if (biEP6.Enabled) RefreshEP6(Sdesc);

                this.cbSpecies.Enabled = biEP2.Enabled;

                
			} 
			finally 
			{
                SetCharacterAttributesVisibility();
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

            this.pbPetEating.Value = sdesc.Interests.Environment;
            this.pbPetWeather.Value = sdesc.Interests.Food;
            this.pbPetPlaying.Value = sdesc.Interests.Culture;
            this.pbPetSpooky.Value = sdesc.Interests.Money;
            this.pbPetSleep.Value = sdesc.Interests.Entertainment;
            this.pbPetToy.Value = sdesc.Interests.Health;
            this.pbPetPets.Value = sdesc.Interests.Politics;
            this.pbPetOutside.Value = sdesc.Interests.Crime;
            this.pbPetAnimals.Value = sdesc.Interests.Fashion;
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
				foreach (Control c in this.pnHumanChar.Controls)
					if (c is LabeledProgressBar)
						((LabeledProgressBar)c).Value = ((LabeledProgressBar)c).Maximum;
				intern = false;	this.ChangedChar(null, null);
			}
			else if(this.pnInt.Visible) 
			{
				intern = true;
				foreach (Control c in this.pnPetInt.Controls)
					if (c is LabeledProgressBar)
						((LabeledProgressBar)c).Value = ((LabeledProgressBar)c).Maximum;
                foreach (Control c in this.pnSimInt.Controls)
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
                        lv_SelectedSimChanged(lv, null, null);
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
                foreach (Control c in pnHumanChar.Controls)
					if (c is LabeledProgressBar)
						((LabeledProgressBar)c).Value = rnd.Next(((LabeledProgressBar)c).Maximum);
				intern = false;	this.ChangedSkill(null, null);
			}
			else if(this.pnInt.Visible) 
			{
				intern = true;
                foreach (Control c in pnPetInt.Controls)
					if (c is LabeledProgressBar)
						((LabeledProgressBar)c).Value = rnd.Next(((LabeledProgressBar)c).Maximum);
                foreach (Control c in pnSimInt.Controls)
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
                if (IsHumanoid())
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
                }
                else
                {
                    Sdesc.Interests.Environment = (ushort)this.pbPetEating.Value;
                    Sdesc.Interests.Food = (ushort)this.pbPetWeather.Value;
                    Sdesc.Interests.Culture = (ushort)this.pbPetPlaying.Value;
                    Sdesc.Interests.Money = (ushort)this.pbPetSpooky.Value;
                    Sdesc.Interests.Entertainment = (ushort)this.pbPetSleep.Value;
                    Sdesc.Interests.Health = (ushort)this.pbPetToy.Value;
                    Sdesc.Interests.Politics = (ushort)this.pbPetPets.Value;
                    Sdesc.Interests.Crime = (ushort)this.pbPetOutside.Value;
                    Sdesc.Interests.Fashion = (ushort)this.pbPetAnimals.Value;
                }

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
                    this.lv_SelectedSimChanged(lv, null, null);
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
				clb.SetItemChecked(i, ((cur&val)==val)&&val!=0);
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
            cbSpecies.SelectedValue = sdesc.Nightlife.Species;

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
                Sdesc.Nightlife.Species = (SimPe.PackedFiles.Wrapper.SdscNightlife.SpeciesType)cbSpecies.SelectedValue;

                Sdesc.Changed = true;
            }
            finally
            {
                intern = false;
            }
        }

        #endregion

        #region Bon Voyage
        void ShowAllCollectibles()
        {
            if (lvCollectibles.Items.Count > 0) return;
            SimPe.Providers.CollectibleAlias[] al = FileTable.ProviderRegistry.SimDescriptionProvider.GetAllCollectibles();
            foreach (SimPe.Providers.CollectibleAlias a in al)
            {
                ilCollectibles.Images.Add(a.Image);
                ListViewItem lvi = new ListViewItem(a.ToString(), ilCollectibles.Images.Count-1);
                lvi.Tag = a;
                lvCollectibles.Items.Add(lvi);
            }
        }


        void RefreshEP6(Wrapper.ExtSDesc sdesc)
        {
            ShowAllCollectibles();
            tbhdaysleft.Text = sdesc.Voyage.DaysLeft.ToString();

            foreach (ListViewItem lvi in lvCollectibles.Items){
                SimPe.Providers.CollectibleAlias a = (SimPe.Providers.CollectibleAlias)lvi.Tag;
                lvi.Checked = (a.Id & sdesc.Voyage.CollectiblesPlain) == a.Id;
            }
        }

        private void ChangedEP6(object sender, System.EventArgs e)
        {
            if (intern) return;
            intern = true;
            try
            {
                if ((int)Sdesc.Version >= (int)SimPe.PackedFiles.Wrapper.SDescVersions.Voyage)
                {
                    Sdesc.Voyage.CollectiblesPlain = 0;
                    Sdesc.Voyage.DaysLeft = Helper.StringToUInt16(tbhdaysleft.Text, Sdesc.Voyage.DaysLeft, 10);
                    foreach (ListViewItem lvi in lvCollectibles.Items)
                    {
                        SimPe.Providers.CollectibleAlias a = (SimPe.Providers.CollectibleAlias)lvi.Tag;
                        if (lvi.Checked) Sdesc.Voyage.CollectiblesPlain = Sdesc.Voyage.CollectiblesPlain | a.Id;
                    }

                    Sdesc.Changed = true;
                }
            }
            finally
            {
                intern = false;
            }
        }
        #endregion

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
            this.ptGifted.SetTraitLevel(0, 1, sdesc.Pets.PetTraits);
            this.ptHyper.SetTraitLevel(2, 3, sdesc.Pets.PetTraits);
            this.ptIndep.SetTraitLevel(4, 5, sdesc.Pets.PetTraits);
            this.ptAggres.SetTraitLevel(6, 7, sdesc.Pets.PetTraits);
            this.ptPigpen.SetTraitLevel(8, 9, sdesc.Pets.PetTraits);        
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
                    this.ptGifted.UpdateTraits(0, 1, Sdesc.Pets.PetTraits);
                    this.ptHyper.UpdateTraits(2, 3, Sdesc.Pets.PetTraits);
                    this.ptIndep.UpdateTraits(4, 5, Sdesc.Pets.PetTraits);
                    this.ptAggres.UpdateTraits(6, 7, Sdesc.Pets.PetTraits);
                    this.ptPigpen.UpdateTraits(8, 9, Sdesc.Pets.PetTraits);
                    //Sdesc.Changed = true;
                }
            }
            finally
            {
                intern = false;
            }
        }

        
		



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

        private void cbSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool showsim = IsHumanoid();
            pnSimInt.Visible = showsim;
            pnHumanChar.Visible = showsim;
            pnPetChar.Visible = !showsim;
            pnPetInt.Visible = !showsim;            
        }

        private bool IsHumanoid()
        {
            SimPe.PackedFiles.Wrapper.SdscNightlife.SpeciesType sp = (SimPe.PackedFiles.Wrapper.SdscNightlife.SpeciesType)cbSpecies.SelectedValue;
            bool showsim = sp == SimPe.PackedFiles.Wrapper.SdscNightlife.SpeciesType.Human;
            return showsim;
        }

        private void SetCharacterAttributesVisibility()
        {
            return;
            bool showsim = true;
            if (Sdesc == null)
            {
                showsim = true;

            }
            else
            {

                if ((int)Sdesc.Version >= (int)SimPe.PackedFiles.Wrapper.SDescVersions.Pets)
                    showsim = Sdesc.Nightlife.IsHuman;
                else showsim = true;
            }

            pnHumanChar.Visible = showsim;
            pnPetChar.Visible = !showsim;

            this.pnSimInt.Visible = showsim;
            this.pnPetInt.Visible = !showsim;
        }

        private void pnInt_VisibleChanged(object sender, EventArgs e)
        {
            cbSpecies_SelectedIndexChanged(null, null);
        }

        private void pnSimInt_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void activate_miOpenScore(object sender, EventArgs e)
        {
            try
            {
                Interfaces.Files.IPackedFileDescriptor pfd = Sdesc.Package.NewDescriptor(0x3053CF74, Sdesc.FileDescriptor.Type, Sdesc.FileDescriptor.Group, Sdesc.FileDescriptor.Instance); //try a SCOR File
                pfd = Sdesc.Package.FindFile(pfd);
                SimPe.RemoteControl.OpenPackedFile(pfd, Sdesc.Package);
            }
            catch (Exception ex)
            {
                Helper.ExceptionMessage(ex);
            }
        }

        private void lbcollectibles_Click(object sender, EventArgs e)
        {

        }

        private void lvCollectibles_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ChangedEP6(sender, e);
        }

       

		

		

		

		
	}
}
