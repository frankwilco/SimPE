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
using SimPe.Cache;
using SimPe.PackedFiles.Wrapper;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;
using SimPe.Interfaces.Plugin.Scanner;

namespace SimPe.Plugin.Scanner
{
	/// <summary>
	/// This class is retriving the Name of a Package
	/// </summary>
	internal class ClothingScanner : AbstractScanner, IScanner
	{		
		public ClothingScanner () : base () { }

	    #region IScannerBase Member
		public uint Version 
		{
			get { return 1; }
		}

		public int Index 
		{
			get { return 600; }
		}
		#endregion

		#region IScanner Member

		protected override void DoInitScan()
		{
			AbstractScanner.AddColumn(ListView, "Ages", 150);
			AbstractScanner.AddColumn(ListView, "Categories", 150);
		}


		public void ScanPackage(ScannerItem si, SimPe.Cache.PackageState ps, System.Windows.Forms.ListViewItem lvi)
		{		
			if (si.PackageCacheItem.Type == SimPe.Cache.PackageType.Cloth || 
				si.PackageCacheItem.Type == SimPe.Cache.PackageType.Skin ||
				((uint)si.PackageCacheItem.Type & (uint)SimPe.Cache.PackageType.Makeup) == (uint)SimPe.Cache.PackageType.Makeup || 
				((uint)si.PackageCacheItem.Type & (uint)SimPe.Cache.PackageType.Accessory) == (uint)SimPe.Cache.PackageType.Accessory || 
				si.PackageCacheItem.Type == SimPe.Cache.PackageType.Hair 
				) 
			{
				Interfaces.Files.IPackedFileDescriptor[] pfds = si.Package.FindFiles(Data.MetaData.GZPS);
				if (pfds.Length==0) pfds = si.Package.FindFiles(0xCCA8E925); //Object XML
				if (pfds.Length==0) pfds = si.Package.FindFiles(0x2C1FD8A1); //TextureOverlay XML
				if (pfds.Length==0) pfds = si.Package.FindFiles(0x8C1580B5); //Hairtone XML
				if (pfds.Length==0) pfds = si.Package.FindFiles(0x0C1FE246); //Mesh Overlay XML

				ArrayList data = new ArrayList();
				foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
				{
					SimPe.PackedFiles.Wrapper.Cpf cpf = new Cpf();
					cpf.ProcessData(pfd, si.Package, false);

					data.Add(cpf.GetSaveItem("age").UIntegerValue);
					data.Add(cpf.GetSaveItem("category").UIntegerValue);
				}

				ps.Data = new uint[data.Count];
				data.CopyTo(ps.Data);
				ps.State = TriState.True;
			} 
			else 
			{
				ps.State = TriState.False;
			}

			UpdateState(si, ps, lvi);
		}

		public void UpdateState(ScannerItem si, SimPe.Cache.PackageState ps, System.Windows.Forms.ListViewItem lvi)
		{				
			AbstractScanner.SetSubItem(lvi, this.StartColum+1, "");

			System.Drawing.Color cl = lvi.ForeColor;
			if (ps.State == TriState.True) 
			{
				uint c = 0;
				uint a = 0;
				for (int i=0;i<ps.Data.Length-1; i+=2) 
				{
					c |= ps.Data[i+1];
					a |= ps.Data[i];
				}

				string age="";
				Data.Ages[] ages = (Data.Ages[])System.Enum.GetValues(typeof(Data.Ages));
				foreach (Data.Ages ag in ages) 
				{					
					if ((a&(uint)ag)!=0) 
					{
						if (age!="") age +=", ";
						age += ag.ToString();
					}
				}
				if (a==0) 
					cl = System.Drawing.Color.Red;
				AbstractScanner.SetSubItem(lvi, this.StartColum, age, cl);

				if (si.PackageCacheItem.Type != SimPe.Cache.PackageType.Skin) 
				{
					string category="";				
					Data.SkinCategories[] cats = (Data.SkinCategories[])System.Enum.GetValues(typeof(Data.SkinCategories));
					foreach (Data.SkinCategories cat in cats) 
					{
						
						if ((c&(uint)cat)!=0) 
						{
							if (category!="") category +=", ";
							category += cat.ToString();
						}
					}
					if (c==0) 
						cl = System.Drawing.Color.Red;
					AbstractScanner.SetSubItem(lvi, this.StartColum+1, category, cl);
				}				
				
			}
		}

		public void FinishScan() { }

		public override bool IsActiveByDefault
		{
			get { return true; }
		}	
	
		ScannerItem[] selection;
		public override void EnableControl(ScannerItem[] items, bool active)
		{
			selection = items;
			if (!active) 
			{
				this.OperationControl.Enabled = false;
				return;
			}

			bool en = false;			

			int[] agect = new int[ScannerPanelForm.Form.cbages.Length];
			for (int i=0; i<agect.Length; i++)  agect[i] = 0;
			int[] catct = new int[ScannerPanelForm.Form.cbcategories.Length];
			for (int i=0; i<catct.Length; i++)  catct[i] = 0;

			int maxagecount = 0;
			foreach (ScannerItem si in items) 
			{
				SimPe.Cache.PackageState ps = si.PackageCacheItem.FindState(this.Uid, true);
				for (int ct=0; ct<ps.Data.Length-1; ct+=2) 
				{			
					en = true;
					maxagecount++;
					for (int i=0; i<agect.Length; i++) 
						if ((ps.Data[ct]&(uint)ScannerPanelForm.Form.cbages[i].Tag)!=0) agect[i]++;					
					for (int i=0; i<catct.Length; i++) 
						if ((ps.Data[ct+1]&(uint)ScannerPanelForm.Form.cbcategories[i].Tag)!=0) catct[i]++;	
				} //for ct
			}

			//Set the State of the Checkboxes
			for (int i=0; i<agect.Length; i++) 
			{
				if (agect[i]==0) ScannerPanelForm.Form.cbages[i].CheckState = System.Windows.Forms.CheckState.Unchecked;
				else if (agect[i]==maxagecount) ScannerPanelForm.Form.cbages[i].CheckState = System.Windows.Forms.CheckState.Checked;				
				else ScannerPanelForm.Form.cbages[i].CheckState = System.Windows.Forms.CheckState.Indeterminate;
			}			

			//Set the State of the Checkboxes
			for (int i=0; i<catct.Length; i++) 
			{
				if (catct[i]==0) ScannerPanelForm.Form.cbcategories[i].CheckState = System.Windows.Forms.CheckState.Unchecked;
				else if (catct[i]==maxagecount) ScannerPanelForm.Form.cbcategories[i].CheckState = System.Windows.Forms.CheckState.Checked;
				else ScannerPanelForm.Form.cbcategories[i].CheckState = System.Windows.Forms.CheckState.Indeterminate;
			}

			this.OperationControl.Enabled = en;
		}


		protected override System.Windows.Forms.Control CreateOperationControl()
		{
			ScannerPanelForm.Form.pncloth.Tag = this;
			return ScannerPanelForm.Form.pncloth;
		}

		#endregion

		void AddUniversityFields(SimPe.PackedFiles.Wrapper.Cpf cpf)
		{
			if (cpf.GetItem("product") == null) 
			{
				SimPe.PackedFiles.Wrapper.CpfItem i = new SimPe.PackedFiles.Wrapper.CpfItem();
				i.Name = "product";
				i.UIntegerValue = 1;
				cpf.AddItem(i);
			}

			if (cpf.GetItem("version") == null) 
			{
				SimPe.PackedFiles.Wrapper.CpfItem i = new SimPe.PackedFiles.Wrapper.CpfItem();
				i.Name = "version";
				i.UIntegerValue = 2;
				cpf.AddItem(i);
			}
		}

		/// <summary>
		/// Set the Age of the Files
		/// </summary>
		/// <param name="name"></param>
		/// <param name="cbs"></param>
		/// <param name="yacheck">true, if you want to perform a check for YoungAdulst and add apropriate Filds to the cpf</param>
		void SetProperty(string name, CheckBox[] cbs, bool yacheck)
		{
			if (selection==null) return;

			WaitingScreen.Wait();
			try 
			{
				bool chg = false;
				foreach (ScannerItem si in selection) 
				{
					if (si.PackageCacheItem.Type == SimPe.Cache.PackageType.Cloth || 
						si.PackageCacheItem.Type == SimPe.Cache.PackageType.Skin ||
						((uint)si.PackageCacheItem.Type & (uint)SimPe.Cache.PackageType.Makeup) == (uint)SimPe.Cache.PackageType.Makeup || 
						((uint)si.PackageCacheItem.Type & (uint)SimPe.Cache.PackageType.Accessory) == (uint)SimPe.Cache.PackageType.Accessory || 
						si.PackageCacheItem.Type == SimPe.Cache.PackageType.Hair 
						) 
					{
						if (si.PackageCacheItem.Thumbnail!=null) WaitingScreen.Update(si.PackageCacheItem.Thumbnail, si.FileName);
						else WaitingScreen.UpdateMessage(si.FileName);

						//make sure, the file is rescanned on the next Cache Update
						SimPe.Cache.PackageState ps = si.PackageCacheItem.FindState(this.Uid, true);
						ps.State = TriState.Null;

						Interfaces.Files.IPackedFileDescriptor[] pfds = si.Package.FindFiles(Data.MetaData.GZPS);
						if (pfds.Length==0) pfds = si.Package.FindFiles(0xCCA8E925); //Object XML
						if (pfds.Length==0) pfds = si.Package.FindFiles(0x2C1FD8A1); //TextureOverlay XML
						if (pfds.Length==0) pfds = si.Package.FindFiles(0x8C1580B5); //Hairtone XML
						if (pfds.Length==0) pfds = si.Package.FindFiles(0x0C1FE246); //Mesh Overlay XML

						ArrayList data = new ArrayList();
						foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
						{
							SimPe.PackedFiles.Wrapper.Cpf cpf = new Cpf();
							cpf.ProcessData(pfd, si.Package, false);

							uint age = cpf.GetSaveItem(name).UIntegerValue;
							foreach (CheckBox cb in cbs) 
							{
								if (cb.CheckState == CheckState.Indeterminate) continue;

								age |= (uint)cb.Tag;
								if (cb.CheckState == CheckState.Unchecked) age ^= (uint)cb.Tag;
							}

							if (yacheck) 
							{
								//when Young Adult is set, we need to make sure that the Version is updated accordingly!
								if ((age&(uint)Data.Ages.YoungAdult)!=0) AddUniversityFields(cpf);
							}

							if (cpf.GetSaveItem(name).UIntegerValue!=age) chg=true;
							cpf.GetSaveItem(name).UIntegerValue = age;

							cpf.SynchronizeUserData();
						}	
					
						si.Package.Save();
					} 
					


				}//foreach
				if (chg && this.CallbackFinish!=null) this.CallbackFinish(false, false);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
			finally 
			{
				WaitingScreen.Stop();
			}
		}

		/// <summary>
		/// Set the Age of the Files
		/// </summary>
		public void SetAge()
		{
			SetProperty("age", ScannerPanelForm.Form.cbages, true);
		}

		/// <summary>
		/// Set the Category of the Files
		/// </summary>
		public void SetCategory() 
		{
			SetProperty("category", ScannerPanelForm.Form.cbcategories, false);
		}

		public override string ToString()
		{
			return "Clothing Scanner";
		}		
	}
}
