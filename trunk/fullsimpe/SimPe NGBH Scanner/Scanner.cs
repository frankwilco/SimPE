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
using SimPe.Cache;
using SimPe.Interfaces.Plugin.Scanner;
using System.Drawing;
using SimPe.Plugin.Scanner;

namespace SimPe.Plugin
{
	/// <summary>
	/// This class is retriving the Name of a Package
	/// </summary>
	internal class NeighborhoodScanner : AbstractScanner, IScanner
	{
		ArrayList ids;
		public NeighborhoodScanner () : base () 
		{
			ids = new ArrayList();
		}

		public void LoadThumbnail(ScannerItem si, SimPe.Cache.PackageState ps) 
		{
			
			if (si.PackageCacheItem.Type == PackageType.Neighborhood) 
			{
				string name = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(si.FileName), System.IO.Path.GetFileNameWithoutExtension(si.FileName))+".png";
				if (System.IO.File.Exists(name))
				{
					Image img = Image.FromFile(name);
					si.PackageCacheItem.Thumbnail = ImageLoader.Preview(img, AbstractScanner.ThumbnailSize);
				}
			}
		}
		
		#region IScannerBase Member
		public uint Version 
		{
			get { return 1; }
		}

		public int Index 
		{
			get { return 700; }
		}
		#endregion
		
		#region IScanner Member		
		protected override void DoInitScan()
		{
			ListView.SmallImageList = ListView.LargeImageList;
			ids.Clear();
			AbstractScanner.AddColumn(this.ListView, "Neighborhood Type", 100);
			AbstractScanner.AddColumn(this.ListView, "Neighborhood UID", 50);
		}

		

		public void ScanPackage(ScannerItem si, SimPe.Cache.PackageState ps, System.Windows.Forms.ListViewItem lvi)
		{
			this.LoadThumbnail(si, ps);

			if (si.PackageCacheItem.Type == PackageType.Neighborhood) 
			{
				Interfaces.Files.IPackedFileDescriptor[] pfds = si.Package.FindFiles(Data.MetaData.IDNO);
				if (pfds.Length>0) 
				{
					Idno idno = new Idno();
					idno.ProcessData(pfds[0], si.Package);

					ps.Data = new uint[2];
					ps.Data[0] = (uint)idno.Type;
					ps.Data[1] = idno.Uid;

					//check for duplicates
					if (ids.Contains(idno.Uid)) ps.State = TriState.False;
					else ps.State = TriState.True;										
				}
			}

			if (si.PackageCacheItem.Thumbnail!=null) WaitingScreen.UpdateImage(si.PackageCacheItem.Thumbnail);
			UpdateState(si, ps, lvi);
		}

		public void UpdateState(ScannerItem si, SimPe.Cache.PackageState ps, System.Windows.Forms.ListViewItem lvi)
		{		
			AbstractScanner.SetSubItem(lvi, this.StartColum+1, "");
			if (si.PackageCacheItem.Type == PackageType.Neighborhood) 
			{
				if (si.PackageCacheItem.Thumbnail==null) this.LoadThumbnail(si, ps);			

				//Add the Thumbnail if available
				if (si.PackageCacheItem.Thumbnail!=null) 
				{
					ListView.SmallImageList.Images.Add(si.PackageCacheItem.Thumbnail);
					lvi.ImageIndex = ListView.SmallImageList.Images.Count-1;
				} 

				if (ps.Data.Length>1) 
				{		
					ids.Add(ps.Data[1]);
					AbstractScanner.SetSubItem(lvi, this.StartColum, ((NeighborhoodType)ps.Data[0]).ToString());					
					AbstractScanner.SetSubItem(lvi, this.StartColum+1, "0x"+Helper.HexString(ps.Data[1]), ps);
				}
			}
		}

		public void FinishScan() { }	
		
		protected override System.Windows.Forms.Control CreateOperationControl()
		{
			Skybound.VisualStyles.VisualStyleLinkLabel ll = new Skybound.VisualStyles.VisualStyleLinkLabel();
			ll.AutoSize = true;
			ll.Text = "Create Unique ID";
			ll.Font = new System.Drawing.Font("Verdana", ll.Font.Size, System.Drawing.FontStyle.Bold);

			ll.LinkClicked +=new System.Windows.Forms.LinkLabelLinkClickedEventHandler(MakeUnique);
			return ll;
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
			foreach (ScannerItem si in items) 
			{
				if (si.PackageCacheItem.Type == PackageType.Neighborhood) 
				{
					en = true;
					break;
				}
			}
			OperationControl.Enabled = en;
		}


		#endregion

		public override string ToString()
		{
			return "Neighborhood Scanner";
		}

		private void MakeUnique(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (selection==null) return;

			WaitingScreen.Wait();
			bool chg = false;
			try 
			{
				Hashtable ids = Idno.FindUids(Helper.WindowsRegistry.SimSavegameFolder, true);
				foreach (ScannerItem si in selection) 
				{					
					if (si.PackageCacheItem.Thumbnail!=null) WaitingScreen.Update(si.PackageCacheItem.Thumbnail, si.FileName);
					else WaitingScreen.UpdateMessage(si.FileName);

					SimPe.Cache.PackageState ps = si.PackageCacheItem.FindState(this.Uid, true);
					if (si.PackageCacheItem.Type == PackageType.Neighborhood)
					{
						Interfaces.Files.IPackedFileDescriptor[] pfds = si.Package.FindFiles(Data.MetaData.IDNO);
						if (pfds.Length>0) 
						{
							Idno idno = new Idno();
							idno.ProcessData(pfds[0], si.Package);
							idno.MakeUnique(ids);
							

							if (ps.Data.Length<2) ps.Data = new uint[2];
							if (idno.Uid!=ps.Data[1]) 
							{
								idno.SynchronizeUserData();
								si.Package.Save();
								chg = true;

								ps.Data[1] = idno.Uid;
								ps.State = TriState.True;
							}
						}
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
