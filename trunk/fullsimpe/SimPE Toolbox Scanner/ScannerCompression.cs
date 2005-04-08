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
	internal class CompressionScanner : AbstractScanner, IScanner
	{		
		public enum CompressionState : uint 
		{
			Ok = 0x0,
			UnknownVersion = 0x1,
			IncompleteDirectory = 0x02,
			WrongCompressionSize = 0x04,
			WrongDirectory = 0x08
		}

		public CompressionScanner (System.Windows.Forms.ListView lv) : base (lv) { }

		
		#region IScannerBase Member
		public uint Version 
		{
			get { return 1; }
		}

		public int Index 
		{
			get { return 400; }
		}
		#endregion

		#region IScanner Member

		protected override void DoInitScan()
		{
			AbstractScanner.AddColumn(ListView, "Compression", 100);
		}


		public void ScanPackage(ScannerItem si, SimPe.Cache.PackageState ps, System.Windows.Forms.ListViewItem lvi)
		{		
			ps.Data = new uint[1];
			ps.State = TriState.True;
			ps.Data[0] = (uint)CompressionState.Ok;
			if (si.Package.Header.Version != 0x100000001) 
			{
				ps.Data[0] = (uint)CompressionState.UnknownVersion;
			} 
			else 
			{
				if (si.Package.FileListFile != null) 
				{
					foreach (SimPe.PackedFiles.Wrapper.ClstItem item in si.Package.FileListFile.Items) 
					{
						SimPe.Interfaces.Files.IPackedFileDescriptor p = si.Package.FindFile(item.Type, item.SubType, item.Group, item.Instance);
						if (p==null) 
						{
							ps.Data[0] = (uint)CompressionState.WrongDirectory;
							break;
						}						
					}

					if (ps.Data[0] == (uint)CompressionState.Ok) 
					{
						foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in si.Package.Index) 
						{
							SimPe.Interfaces.Files.IPackedFile fl = si.Package.Read(pfd);
							if (!fl.IsCompressed) continue;

							int pos = si.Package.FileListFile.FindFile(pfd);
							if (pos==-1) 
							{
								ps.Data[0] = (uint)CompressionState.IncompleteDirectory;
								break;
							}

							SimPe.PackedFiles.Wrapper.ClstItem item  = si.Package.FileListFile.Items[pos];
							if (fl.UncompressedSize != item.UncompressedSize) 
							{
								ps.Data[0] = (uint)CompressionState.WrongCompressionSize;
								break;
							}
						}
					}

				}
				if (ps.Data[0] != (uint)CompressionState.Ok) ps.State = TriState.False;
			}

			UpdateState(si, ps, lvi);
		}

		public void UpdateState(ScannerItem si, SimPe.Cache.PackageState ps, System.Windows.Forms.ListViewItem lvi)
		{	
			if (ps.State != TriState.Null) 
			{
				CompressionState cs = (CompressionState)ps.Data[0];
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

			foreach (ScannerItem item in items) 
			{
				SimPe.Cache.PackageState ps = item.PackageCacheItem.FindState(this.Uid, true);
				if ((ps.State != TriState.Null) && (ps.Data.Length>0))
				{
					if ((CompressionState)ps.Data[0]!=CompressionState.Ok) 
					{
						OperationControl.Enabled = true;
						return;
					}
				}
			} //foreach 
			OperationControl.Enabled = false;
		}


		protected override System.Windows.Forms.Control CreateOperationControl()
		{
			Skybound.VisualStyles.VisualStyleLinkLabel ll = new Skybound.VisualStyles.VisualStyleLinkLabel();
			ll.AutoSize = true;
			ll.Text = "fix Compression";
			ll.Font = new System.Drawing.Font("Verdana", ll.Font.Size, System.Drawing.FontStyle.Bold);

			ll.LinkClicked +=new System.Windows.Forms.LinkLabelLinkClickedEventHandler(FixCompression);
			return ll;
		}

		#endregion

		public override string ToString()
		{
			return "Compression Scanner";
		}

		/// <summary>
		/// this Operation is fixing selected Packages that wer marked as problematic
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FixCompression(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
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
					if ((ps.State != TriState.Null) && (ps.Data.Length>0))
					{
						if ((CompressionState)ps.Data[0]!=CompressionState.Ok) 
						{
							foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in si.Package.Index) 
							{
								SimPe.Interfaces.Files.IPackedFile file = si.Package.Read(pfd);
								pfd.UserData = file.UncompressedData;

								pfd.MarkForReCompress = (file.IsCompressed || Data.MetaData.CompressionCandidates.Contains(pfd.Type));							
							}

							si.Package.Save();
							ps.State = TriState.True;
							ps.Data[0] = (uint)CompressionState.Ok;
							chg = true;
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
