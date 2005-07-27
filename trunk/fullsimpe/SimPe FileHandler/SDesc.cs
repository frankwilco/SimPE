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
using System.Windows.Forms;
using System.Drawing;
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces;
using SimPe.PackedFiles.Wrapper.Supporting;
using SimPe.Data;
using System.Threading;
using System.Reflection;
using System.Reflection.Emit;


namespace SimPe.PackedFiles.UserInterface
{
	/// <summary>
	/// handles Packed SDSC Files
	/// </summary>
	public class SDesc : UIBase, IPackedFileUI
	{
		static AssemblyBuilder myAssemblyBuilder;
		static ModuleBuilder myModuleBuilder;
		static EnumBuilder myEnumBuilder;
		

		/// <summary>
		/// Creates a new Instance and fills the aspiration Types into the correct Form
		/// </summary>
		protected void ResetUI(Wrapper.SDesc sdesc) 
		{
			form.cboutfamtype.Items.Clear();
			form.cboutfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Unset_Unknown));
			form.cboutfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Aunt));
			form.cboutfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Child));
			form.cboutfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Cousin));
			form.cboutfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Grandchild));
			form.cboutfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Gradparent));
			form.cboutfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Nice_Nephew));
			form.cboutfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Parent));
			form.cboutfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Sibling));
			form.cboutfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Spouses));

			form.cbinfamtype.Items.Clear();
			form.cbinfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Unset_Unknown));
			form.cbinfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Aunt));
			form.cbinfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Child));
			form.cbinfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Cousin));
			form.cbinfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Grandchild));
			form.cbinfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Gradparent));
			form.cbinfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Nice_Nephew));
			form.cbinfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Parent));
			form.cbinfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Sibling));
			form.cbinfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Spouses));

			form.cbaspiration.Items.Clear();
			form.cbaspiration.Items.Add(new LocalizedAspirationTypes(Data.MetaData.AspirationTypes.Nothing));
			form.cbaspiration.Items.Add(new LocalizedAspirationTypes(Data.MetaData.AspirationTypes.Fortune));
			form.cbaspiration.Items.Add(new LocalizedAspirationTypes(Data.MetaData.AspirationTypes.Family));
			form.cbaspiration.Items.Add(new LocalizedAspirationTypes(Data.MetaData.AspirationTypes.Knowledge));
			form.cbaspiration.Items.Add(new LocalizedAspirationTypes(Data.MetaData.AspirationTypes.Reputation));
			form.cbaspiration.Items.Add(new LocalizedAspirationTypes(Data.MetaData.AspirationTypes.Romance));
			form.cbaspiration.Items.Add(new LocalizedAspirationTypes(Data.MetaData.AspirationTypes.Growup));

			
			form.cblifesection.Items.Clear();
			form.cblifesection.Items.Add(new LocalizedLifeSections(Data.MetaData.LifeSections.Unknown));
			form.cblifesection.Items.Add(new LocalizedLifeSections(Data.MetaData.LifeSections.Baby));
			form.cblifesection.Items.Add(new LocalizedLifeSections(Data.MetaData.LifeSections.Toddler));
			form.cblifesection.Items.Add(new LocalizedLifeSections(Data.MetaData.LifeSections.Child));
			form.cblifesection.Items.Add(new LocalizedLifeSections(Data.MetaData.LifeSections.Teen));
			//form.cblifesection.Items.Add(new LocalizedLifeSections(Data.MetaData.LifeSections.YoungAdult));
			form.cblifesection.Items.Add(new LocalizedLifeSections(Data.MetaData.LifeSections.Adult));
			form.cblifesection.Items.Add(new LocalizedLifeSections(Data.MetaData.LifeSections.Elder));

			form.cbcareer.Items.Clear();
			foreach (SimPe.Interfaces.IAlias a in Wrapper.SDesc.AddonCarrers) form.cbcareer.Items.Add(a);
			form.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Unknown));
			form.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Unemployed));
			form.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Science));
			form.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Medical));
			form.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Politics));
			form.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Athletic));
			form.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.LawEnforcement));
			form.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Culinary));
			form.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Business));
			form.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Slacker));
			form.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Criminal));
			form.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Military));
			
			form.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.TeenElderAthletic));
			form.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.TeenElderBusiness));
			form.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.TeenElderCriminal));
			form.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.TeenElderCulinary));
			form.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.TeenElderLawEnforcement));
			form.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.TeenElderMedical));
			form.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.TeenElderMilitary));
			form.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.TeenElderPolitics));
			form.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.TeenElderScience));
			form.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.TeenElderSlacker));			
			if ((Helper.WindowsRegistry.EPInstalled>=1) || (Helper.WindowsRegistry.HiddenMode))
			{
				form.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Paranormal));
				form.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.NaturalScientist));
				form.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.ShowBiz));
				form.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Artist));
			}

			form.cbgrade.Items.Clear();
			form.cbgrade.Items.Add(new LocalizedGrades(Data.MetaData.Grades.Unknown));
			form.cbgrade.Items.Add(new LocalizedGrades(Data.MetaData.Grades.APlus));
			form.cbgrade.Items.Add(new LocalizedGrades(Data.MetaData.Grades.A));
			form.cbgrade.Items.Add(new LocalizedGrades(Data.MetaData.Grades.AMinus));
			form.cbgrade.Items.Add(new LocalizedGrades(Data.MetaData.Grades.BPlus));
			form.cbgrade.Items.Add(new LocalizedGrades(Data.MetaData.Grades.B));
			form.cbgrade.Items.Add(new LocalizedGrades(Data.MetaData.Grades.BMinus));
			form.cbgrade.Items.Add(new LocalizedGrades(Data.MetaData.Grades.CPlus));
			form.cbgrade.Items.Add(new LocalizedGrades(Data.MetaData.Grades.C));
			form.cbgrade.Items.Add(new LocalizedGrades(Data.MetaData.Grades.CMinus));
			form.cbgrade.Items.Add(new LocalizedGrades(Data.MetaData.Grades.DPlus));
			form.cbgrade.Items.Add(new LocalizedGrades(Data.MetaData.Grades.D));
			form.cbgrade.Items.Add(new LocalizedGrades(Data.MetaData.Grades.DMinus));
			form.cbgrade.Items.Add(new LocalizedGrades(Data.MetaData.Grades.F));			

			form.cbmajor.Items.Clear();
			
			foreach (SimPe.Interfaces.IAlias a in Wrapper.SDesc.AddonMajors) form.cbmajor.Items.Add(a);
			System.Array majors = System.Enum.GetValues(typeof(Data.Majors));
			foreach (Data.Majors c in majors) form.cbmajor.Items.Add(c);

			form.cbschooltype.Items.Clear();
			System.Array schools = System.Enum.GetValues(typeof(Data.MetaData.SchoolTypes));
			foreach (Data.MetaData.SchoolTypes c in schools) form.cbschooltype.Items.Add(new LocalizedSchoolType(c));
			foreach (SimPe.Interfaces.IAlias a in Wrapper.SDesc.AddonSchools) form.cbschooltype.Items.Add(a);

			form.gbout.Enabled = false;
			form.gbin.Enabled = false;
			form.llsimrelcommit.Enabled = false;		
			form.btaddtie.Enabled = false;
			form.btdeletetie.Enabled = false;

			form.tboutrelshort.Text = "";
			form.tbinrelshort.Text = "";
			form.tboutrellong.Text = "";
			form.tbinrellong.Text = "";

			form.cballrelsims.Items.Clear();
			form.cballrelsims.Sorted = false;
			foreach (IAlias a in sdesc.NameProvider.StoredData.Values)
			{
				form.cballrelsims.Items.Add(a);
			}
			form.cballrelsims.Sorted = true;

#if DEBUG			
#else
			//form.cblifesection.Enabled = false;
			//form.pblifelinepoints.Enabled = false;
			//form.tblifelinepoints.Enabled = false;
			form.tbcareervalue.Enabled = false;
			form.tbschooltype.Enabled = false;
			//form.gb.Enabled = false;
#endif

			form.cbzodiac.Items.Clear();
			for (ushort i=0x01; i<=0x0C; i++) form.cbzodiac.Items.Add(new LocalizedZodiacSignes((Data.MetaData.ZodiacSignes)i));
		}

		#region IPackedFileHandler Member

		public Control GUIHandle
		{
			get 
			{
				return form.sdescPanel;
			}
		}

		public void UpdateGUI(SimPe.Interfaces.Plugin.IFileWrapper wrapper)
		{						
			Wrapper.SDesc sdesc = (Wrapper.SDesc)wrapper;
			form.wrapper = sdesc;
			ResetUI(sdesc);

			form.tbmajor.Visible = true;
			form.tbmajor.ReadOnly = !Helper.WindowsRegistry.HiddenMode;

			//Relations
			form.lbrelations.Items.Clear();

			foreach (ushort u in sdesc.Relations.SimInstances) 
			{
				Wrapper.SDesc simdesc = sdesc.Relations.GetSimDescription(u);
				if (simdesc!=null) 
				{
					SimRelations rel = sdesc.Relations.GetSimRelationships(u);

					if (rel != null) 
					{
						rel.NameTag = "(0x"+Helper.HexString(u)+")";
						rel.NameTag = simdesc.SimName +" "+simdesc.SimFamilyName+" "+rel.NameTag;									
						form.lbrelations.Items.Add(rel);
					}
				}				
			}

			//Filename
			if (sdesc.CharacterFileName!=null) 
			{
				form.lbfilename.Text = sdesc.CharacterFileName + "   ("+Localization.Manager.GetString("rightclickcopy")+")";
				form.lbfilename.Tag = sdesc.CharacterFileName;
			} 
			else 
			{
				form.lbfilename.Text = Localization.Manager.GetString("filenotfound");
				form.lbfilename.Tag = null;
			}

			form.tbage.Text = sdesc.CharacterDescription.Age.ToString();
			form.tbsimdescname.Text = sdesc.SimName;
			form.tbsimdescfamname.Text = sdesc.SimFamilyName;
			form.tbsim.Text = "0x"+Helper.HexString(sdesc.SimId);
			form.tbsim.ReadOnly = !Helper.WindowsRegistry.HiddenMode;
			form.tbprevdays.Text = sdesc.CharacterDescription.PrevAgeDays.ToString();
			form.tbagedur.Text = sdesc.CharacterDescription.AgeDuration.ToString();
			form.tbunlinked.Text = "0x"+Helper.HexString(sdesc.Unlinked);
			form.pbImage.Image = sdesc.Image;
			
			//Aspiration
			form.cbaspiration.SelectedIndex = 0;
			for (int i=0;i<form.cbaspiration.Items.Count;i++)
			{
				Data.MetaData.AspirationTypes at = (LocalizedAspirationTypes)form.cbaspiration.Items[i];
				if (at==sdesc.CharacterDescription.Aspiration) 
				{
					form.cbaspiration.SelectedIndex = i;
					break;
				}
			}

			//Lifesection
			form.cblifesection.SelectedIndex = 0;
			for (int i=0;i<form.cblifesection.Items.Count;i++)
			{
				Data.MetaData.LifeSections at = (LocalizedLifeSections)form.cblifesection.Items[i];
				if (at==sdesc.CharacterDescription.LifeSection) 
				{
					form.cblifesection.SelectedIndex = i;
					break;
				}
			}

			//Career
			form.tbcareervalue.Text = "0x"+Helper.HexString((uint)sdesc.CharacterDescription.Career);
			form.cbcareer.SelectedIndex = 0;
			for (int i=0;i<form.cbcareer.Items.Count;i++)
			{
				object o = form.cbcareer.Items[i];
				Data.MetaData.Careers at;
				if (o.GetType()==typeof(Alias)) at = (Data.LocalizedCareers)((uint)((Alias)o).Id); 
				else at = (Data.LocalizedCareers)o;
				
				if (at==sdesc.CharacterDescription.Career) 
				{
					form.cbcareer.SelectedIndex = i;
					break;
				}
			}
			form.pbcarrerlevel.Value = Math.Min((ushort)form.pbcarrerlevel.Maximum, sdesc.CharacterDescription.CareerLevel);
			

			//grades and school
			form.cbgrade.SelectedIndex = 0;
			for(int i=0; i<form.cbgrade.Items.Count; i++)
			{
				Data.MetaData.Grades grade;
				object o = form.cbgrade.Items[i];
				if (o.GetType()==typeof(Alias)) grade = (Data.LocalizedGrades)((uint)((Alias)o).Id); 
				else grade = (Data.LocalizedGrades)o;
				if (sdesc.CharacterDescription.Grade == (Data.MetaData.Grades)grade) 
				{
					form.cbgrade.SelectedIndex = i;
					break;
				}
			}

			//University
			if (sdesc.Version==SimPe.PackedFiles.Wrapper.SDescVersions.University) 
			{
				if (!form.tcsdesc.TabPages.Contains(form.tbuni)) form.tcsdesc.TabPages.Add(form.tbuni);
				form.cbmajor.SelectedIndex = 0;
				form.tbmajor.Text = "0x"+Helper.HexString((uint)sdesc.University.Major);		
				form.tbmajor.Visible = Helper.WindowsRegistry.HiddenMode;
				form.cbmajor.SelectedIndex = form.cbmajor.Items.Count -1;
				for (int i=0;i<form.cbmajor.Items.Count;i++)
				{					 
					object o = form.cbmajor.Items[i];
					Data.Majors at;
					if (o.GetType()==typeof(Alias)) at = (Data.Majors)((uint)((Alias)o).Id);
					else at = (Data.Majors)o;
					
					if (at==sdesc.University.Major) 
					{
						form.cbmajor.SelectedIndex = i;
						break;
					}
				}

				form.cboncampus.Checked = (sdesc.University.OnCampus==0x1);
				form.pbeffort.Value = Math.Max(form.pbeffort.Minimum, Math.Min(form.pbeffort.Maximum, sdesc.University.Effort));
				form.pblastgrade.Value = Math.Max(form.pblastgrade.Minimum, Math.Min(form.pblastgrade.Maximum, form.pblastgrade.Maximum - (sdesc.University.Grade / (1000 / (form.pblastgrade.Maximum-form.pblastgrade.Minimum)))));

				form.pbunitime.Value = Math.Max(form.pbunitime.Minimum, Math.Min(form.pbunitime.Maximum, sdesc.University.Time));
				form.tbinfluence.Text = sdesc.University.Influence.ToString();
				form.tbsemester.Text = sdesc.University.Semester.ToString();
			} 
			else 
			{
				if (form.tcsdesc.TabPages.Contains(form.tbuni)) form.tcsdesc.TabPages.Remove(form.tbuni);
			}
			

			form.cbschooltype.SelectedIndex = 0;
			form.tbschooltype.Visible = Helper.WindowsRegistry.HiddenMode;
			for(int i=0; i<form.cbschooltype.Items.Count; i++)
			{
				Data.LocalizedSchoolType type;
				object o = form.cbschooltype.Items[i];
				if (o.GetType()==typeof(Alias)) type = (Data.LocalizedSchoolType)((uint)((Alias)o).Id); 
				else type = (Data.LocalizedSchoolType)o;
				
				if (sdesc.CharacterDescription.SchoolType == (Data.MetaData.SchoolTypes)type) 
				{
					form.cbschooltype.SelectedIndex = i;
					break;
				}
			}

			//ghostflags
			form.cbisghost.Checked = sdesc.CharacterDescription.GhostFlag.IsGhost;
			form.cbpassobject.Checked = sdesc.CharacterDescription.GhostFlag.CanPassThroughObjects;
			form.cbpasswalls.Checked = sdesc.CharacterDescription.GhostFlag.CanPassThroughWalls;
			form.cbpasspeople.Checked = sdesc.CharacterDescription.GhostFlag.CanPassThroughPeople;
			form.cbignoretraversal.Checked = sdesc.CharacterDescription.GhostFlag.IgnoreTraversalCosts;

			//body flags
			form.cbfit.Checked = sdesc.CharacterDescription.BodyFlag.Fit;
			form.cbfat.Checked = sdesc.CharacterDescription.BodyFlag.Fat;
			form.cbpregfull.Checked = sdesc.CharacterDescription.BodyFlag.PregnantFull;
			form.cbpreghalf.Checked = sdesc.CharacterDescription.BodyFlag.PregnantHalf;
			form.cbpreginv.Checked = sdesc.CharacterDescription.BodyFlag.PregnantHidden;

			//Random Data
			form.cbzodiac.SelectedIndex = ((ushort)sdesc.CharacterDescription.ZodiacSign-1);			
			form.rbfemale.Checked = (sdesc.CharacterDescription.Gender == Data.MetaData.Gender.Female);
			form.rbmale.Checked = (sdesc.CharacterDescription.Gender == Data.MetaData.Gender.Male);
			form.pblifelinepoints.Value = sdesc.CharacterDescription.LifelinePoints + 600;
			form.pbblizlifelinepoints.Value = sdesc.CharacterDescription.BlizLifelinePoints;
			form.tblifelinescore.Text = sdesc.CharacterDescription.LifelineScore.ToString();
			form.tbschooltype.Text = "0x"+Helper.HexString((uint)sdesc.CharacterDescription.SchoolType);
			form.tbautonomy.Text = "0x"+Helper.HexString(sdesc.CharacterDescription.AutonomyLevel);
			form.tbnpc.Text = "0x"+Helper.HexString(sdesc.CharacterDescription.NPCType);
			form.pbjobperformance.Value = sdesc.CharacterDescription.CareerPerformance + 1000;
			form.tbfaminst.Text = "0x"+Helper.HexString(sdesc.FamilyInstance);
			form.tbvoice.Text = "0x"+Helper.HexString(sdesc.CharacterDescription.VoiceType);

			//Decay
			form.pbhunger.Value = sdesc.Decay.Hunger + 1000;
			form.pbcomfort.Value = sdesc.Decay.Comfort + 1000;
			form.pbbladder.Value = sdesc.Decay.Bladder + 1000;
			form.pbenergy.Value = sdesc.Decay.Energy + 1000;
			form.pbhygiene.Value = sdesc.Decay.Hygiene + 1000;
			form.pbsocial.Value = sdesc.Decay.Social + 1000;
			form.pbfun.Value = sdesc.Decay.Fun + 1000;

			//Character
			form.pbneat.Value = sdesc.Character.Neat / 100;
			form.pboutgoing.Value = sdesc.Character.Outgoing / 100;
			form.pbactive.Value = sdesc.Character.Active / 100;
			form.pbplayful.Value = sdesc.Character.Playful / 100;
			form.pbnice.Value = sdesc.Character.Nice / 100;

			//Genetic Character
			form.pbgenneat.Value = sdesc.GeneticCharacter.Neat / 100;
			form.pbgenoutgoing.Value = sdesc.GeneticCharacter.Outgoing / 100;
			form.pbgenactive.Value = sdesc.GeneticCharacter.Active / 100;
			form.pbgenplayful.Value = sdesc.GeneticCharacter.Playful / 100;
			form.pbgennice.Value = sdesc.GeneticCharacter.Nice / 100;

			//Skills
			form.pbbody.Value = sdesc.Skills.Body;
			form.pbcharisma.Value = sdesc.Skills.Charisma;
			form.pbcleaning.Value = sdesc.Skills.Cleaning;
			form.pbcooking.Value = sdesc.Skills.Cooking;
			form.pbcreativity.Value = sdesc.Skills.Creativity;
			form.pblogic.Value = sdesc.Skills.Logic;
			form.pbmechanical.Value = sdesc.Skills.Mechanical;
			form.pbfatness.Value = sdesc.Skills.Fatness;
			form.pbromance.Value = sdesc.Skills.Romance;

			//Interests
			form.pbwoman.Value = sdesc.Interests.Woman + 1000;
			form.pbman.Value = sdesc.Interests.Man + 1000;
			form.pbanimals.Value = sdesc.Interests.Animals / 100;
			form.pbcrime.Value = sdesc.Interests.Crime / 100;
			form.pbculture.Value = sdesc.Interests.Culture / 100;
			form.pbentertainment.Value = sdesc.Interests.Entertainment / 100;
			form.pbenvironment.Value = sdesc.Interests.Environment / 100; 
			form.pbfashion.Value = sdesc.Interests.Fashion / 100;
			form.pbfood.Value = sdesc.Interests.Food / 100;
			form.pbhealth.Value = sdesc.Interests.Health / 100;
			form.pbmonei.Value = sdesc.Interests.Money / 100;
			form.pbparanormal.Value = sdesc.Interests.Paranormal / 100;
			form.pbpolitics.Value = sdesc.Interests.Politics / 100;
			form.pbschool.Value = sdesc.Interests.School / 100;
			form.pbscifi.Value = sdesc.Interests.Scifi / 100;
			form.pbsports.Value = sdesc.Interests.Sports / 100;
			form.pbtoys.Value = sdesc.Interests.Toys / 100;
			form.pbtravel.Value = sdesc.Interests.Travel / 100;
			form.pbweather.Value = sdesc.Interests.Weather / 100;
			form.pbwork.Value = sdesc.Interests.Work / 100;
			form.UpdateAllProgressTextValues();	
		
			form.simnamechanged = false;

			//this has to be set after the PB-Update
			form.tbcarrerlevel.Text = sdesc.CharacterDescription.CareerLevel.ToString();
		}

		
		#endregion		
	}
}
