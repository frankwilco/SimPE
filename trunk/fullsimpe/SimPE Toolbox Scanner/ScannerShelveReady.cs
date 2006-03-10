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
using SimPe.Interfaces.Plugin.Scanner;

namespace SimPe.Plugin.Scanner
{
	/// <summary>
	/// This class is retriving the Name of a Package
	/// </summary>
	internal class ShelveScanner : AbstractScanner, IScanner
	{		
		

		public ShelveScanner (System.Windows.Forms.ListView lv) : base (lv) { }

		
		#region IScannerBase Member
		public uint Version 
		{
			get { return 1; }
		}

		public int Index 
		{
			get { return 490; }
		}
		#endregion

		#region IScanner Member

		protected override void DoInitScan()
		{
			AbstractScanner.AddColumn(ListView, "Shelve Dimension", 80);
		}


		public void ScanPackage(ScannerItem si, SimPe.Cache.PackageState ps, System.Windows.Forms.ListViewItem lvi)
		{		
			ps.Data = new uint[1];
			ps.Data[0] = (uint)SimPe.PackedFiles.Wrapper.ShelveDimension.Indetermined;
			ps.State = TriState.True;

			if (si.PackageCacheItem.Type == PackageType.Object || si.PackageCacheItem.Type == PackageType.MaxisObject) 
			{
				SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = si.Package.FindFiles(Data.MetaData.OBJD_FILE);
				
				if (pfds.Length>1) 
				{
					ps.Data[0] = (uint)SimPe.PackedFiles.Wrapper.ShelveDimension.Multitile;
				} 
				else if (pfds.Length>0) 
				{
					SimPe.PackedFiles.Wrapper.ExtObjd objd = new ExtObjd();
					objd.ProcessData(pfds[0], si.Package);
					SimPe.PackedFiles.Wrapper.ShelveDimension sd = objd.ShelveDimension;
					if (sd == SimPe.PackedFiles.Wrapper.ShelveDimension.Unknown1 || sd == SimPe.PackedFiles.Wrapper.ShelveDimension.Indetermined || sd == SimPe.PackedFiles.Wrapper.ShelveDimension.Unknown2)					
						ps.State = TriState.False;	
				
					ps.Data[0] = (uint)sd;					
				}								
			}

			UpdateState(si, ps, lvi);
		}

		public void UpdateState(ScannerItem si, SimPe.Cache.PackageState ps, System.Windows.Forms.ListViewItem lvi)
		{	
			if (ps.State != TriState.Null) 
			{
				SimPe.PackedFiles.Wrapper.ShelveDimension cs = (SimPe.PackedFiles.Wrapper.ShelveDimension)ps.Data[0];
				AbstractScanner.SetSubItem(lvi, this.StartColum, cs.ToString(), ps);
			}
		}

		public void FinishScan() { }

		public override bool IsActiveByDefault
		{
			get { return false; }
		}	
	
		ScannerItem[] selection;
		public override void EnableControl(ScannerItem[] items, bool active)
		{
			selection = items;
			if (!active) 
			{
				OperationControl.Enabled = false;
				return;
			}

			if (items.Length==0) 
			{
				OperationControl.Enabled = false;
			} 
			else if (items.Length == 1)
			{
				SimPe.Cache.PackageState ps = items[0].PackageCacheItem.FindState(this.Uid, true);
				ScannerPanelForm.Form.cbshelve.SelectedValue = (SimPe.PackedFiles.Wrapper.ShelveDimension)ps.Data[0];
				OperationControl.Enabled = true;
			}
			else 
			{
				ScannerPanelForm.Form.cbshelve.SelectedValue = SimPe.PackedFiles.Wrapper.ShelveDimension.Indetermined;
				OperationControl.Enabled = true;
			}
			
		}


		protected override System.Windows.Forms.Control CreateOperationControl()
		{
			ScannerPanelForm.Form.pnShelve.Tag = this;
			return ScannerPanelForm.Form.pnShelve;
		}

		#endregion

		public override string ToString()
		{
			return "OFB Shelve Scanner (by Numenor)";
		}

		/// <summary>
		/// this Operation is fixing selected Packages that wer marked as problematic
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void Set(SimPe.PackedFiles.Wrapper.ShelveDimension sd)
		{
			if (selection==null) return;

			WaitingScreen.Wait();
			bool chg = false;
			try 
			{				
				foreach (ScannerItem si in selection) 
				{			
					if (si.PackageCacheItem.Thumbnail!=null) WaitingScreen.Update(si.PackageCacheItem.Thumbnail, si.FileName);
					else WaitingScreen.UpdateMessage(si.FileName);

					SimPe.Cache.PackageState ps = si.PackageCacheItem.FindState(this.Uid, true);
					if (ps.Data.Length<1) continue;
					if (ps.State == TriState.True && selection.Length>1) continue;
					

					ps.State = TriState.Null;
					try 
					{
						SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = si.Package.FindFiles(Data.MetaData.OBJD_FILE);
				
						foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds){
							SimPe.PackedFiles.Wrapper.ExtObjd objd = new ExtObjd();
							objd.ProcessData(pfd, si.Package);
							objd.ShelveDimension = sd;							
							objd.SynchronizeUserData();								
						}							
	
						si.Package.Save();
					
					} 
					catch (Exception ex)
					{
						Helper.ExceptionMessage("", ex);
					}
				}

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
	}
}
