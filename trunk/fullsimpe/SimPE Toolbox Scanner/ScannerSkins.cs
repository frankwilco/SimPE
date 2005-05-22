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
	internal class SkinScanner : AbstractScanner, IScanner
	{		
		public SkinScanner (System.Windows.Forms.ListView lv) : base (lv) { }

	    #region IScannerBase Member
		public uint Version 
		{
			get { return 1; }
		}

		public int Index 
		{
			get { return 800; }
		}
		#endregion

		#region IScanner Member

		protected override void DoInitScan()
		{
		}


		public void ScanPackage(ScannerItem si, SimPe.Cache.PackageState ps, System.Windows.Forms.ListViewItem lvi)
		{		
			UpdateState(si, ps, lvi);
		}

		public void UpdateState(ScannerItem si, SimPe.Cache.PackageState ps, System.Windows.Forms.ListViewItem lvi)
		{				
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
				OperationControl.Enabled = false;
				return;
			}

			if (items.Length>1) 
			{
				OperationControl.Enabled = false;
				return;
			}

			bool en = false;
			foreach (ScannerItem item in items) 
			{
				SimPe.Cache.PackageState ps = item.PackageCacheItem.FindState(this.Uid, true);
				if (item.PackageCacheItem.Type == PackageType.Skin) 
				{
					en = true;
					break;
				}
			}
			OperationControl.Enabled = en;
		}


		protected override System.Windows.Forms.Control CreateOperationControl()
		{
			ScannerPanelForm.Form.pnskin.Tag = this;
			return ScannerPanelForm.Form.pnskin;
		}

		#endregion

		public override string ToString()
		{
			return "Skintone Scanner";
		}

		/// <summary>
		/// Build an override for another Skin
		/// </summary>
		/// <param name="skintone"></param>
		/// <param name="filename"></param>
		/// <param name="addtxtr">true, if you want to replace the default TXTR Files</param>
		/// <param name="addtxmt">true if you want to replace the default TXMT Files</param>
		public void CreateOverride(string skintone, string filename, bool addtxmt, bool addtxtr)
		{
			if (selection.Length>1) return;

			SimPe.Packages.GeneratableFile pkg = BuildOverride(selection[0], skintone, selection[0].Package, addtxmt, addtxtr);
			pkg.Save(filename);
		}

		/// <summary>
		/// This will build a SkinTone Replacement for the passed Skintone
		/// </summary>
		/// <param name="skintone">the skintone string</param>
		/// <param name="addtxtr">true, if you want to replace the default TXTR Files</param>
		/// <param name="addtxmt">true if you want to replace the default TXMT Files</param>
		/// <param name="sitem"></param>
		/// <param name="src"></param>
		/// <returns>the replacement package</returns>
		public SimPe.Packages.GeneratableFile BuildOverride(ScannerItem sitem, string skintone, SimPe.Interfaces.Files.IPackageFile src, bool addtxmt, bool addtxtr) 
		{
			FileTable.FileIndex.Load();
			SimPe.Packages.GeneratableFile pkg = new SimPe.Packages.GeneratableFile((System.IO.BinaryReader)null);

			WaitingScreen.Wait();
			//Save the old FileTable and the source File
			FileTable.FileIndex.Load();
			FileTable.FileIndex.StoreCurrentState();			
			FileTable.FileIndex.AddIndexFromPackage(src);
			try 
			{
				//find al description Files that belong to the Skintone that should be replaced
				ArrayList basecpf = new ArrayList();
				SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFile(Data.MetaData.GZPS, true);
				foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item in items) 
				{
					SimPe.PackedFiles.Wrapper.Cpf cpf = new Cpf();
					cpf.ProcessData(item);

					if (cpf.GetSaveItem("skintone").StringValue!=skintone) continue;
					if (cpf.GetSaveItem("type").StringValue!="skin") continue;

					SimPe.Plugin.SkinChain sc = new SkinChain(cpf);
					basecpf.Add(sc);
					WaitingScreen.UpdateMessage(cpf.GetSaveItem("name").StringValue);
				}

				ArrayList compare = new ArrayList();
				compare.Add("age");
				compare.Add("category");
				compare.Add("fitness");
				compare.Add("gender");
				compare.Add("outfit");
				compare.Add("override0resourcekeyidx");
				compare.Add("shapekeyidx");

				//now select matching Files
				Interfaces.Files.IPackedFileDescriptor[] pfds = src.FindFiles(Data.MetaData.GZPS);

				
				
				foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
				{
					//load a description File for the new Skintone
					SimPe.PackedFiles.Wrapper.Cpf cpf = new Cpf();
					cpf.ProcessData(pfd, src);

					//check if File is a match
					foreach (SimPe.Plugin.SkinChain sc in basecpf)
					{
						bool use = true;
						//scan for valid CPF Files
						foreach (string s in compare) 
						{
							if (sc.Cpf.GetSaveItem(s).UIntegerValue != cpf.GetSaveItem(s).UIntegerValue) 
							{
								use = false;
								break;
							}
						}

						//yes, yes :D this is a match
						if (use) 
						{
							SkinChain newsc = new SkinChain(cpf);
							if (sc.TXTR!=null && newsc.TXTR!=null && addtxtr) 
							{
								SimPe.Plugin.GenericRcol txtr = newsc.TXTR;
								txtr.FileDescriptor = sc.TXTR.FileDescriptor.Clone();
								txtr.FileDescriptor.MarkForReCompress = true;

								txtr.FileName = sc.TXTR.FileName;

								txtr.SynchronizeUserData();
								if (pkg.FindFile(txtr.FileDescriptor)==null) pkg.Add(txtr.FileDescriptor);
							}

							if (sc.TXMT != null && newsc.TXMT != null && addtxmt) 
							{
								SimPe.Plugin.GenericRcol txmt = newsc.TXMT;
								txmt.FileDescriptor = sc.TXMT.FileDescriptor.Clone();
								txmt.FileDescriptor.MarkForReCompress = true;

								MaterialDefinition md = (MaterialDefinition)txmt.Blocks[0];
								MaterialDefinition mdorg = (MaterialDefinition)sc.TXMT.Blocks[0];
								txmt.FileName = sc.TXMT.FileName;
								md.FileDescription = mdorg.FileDescription;

								txmt.SynchronizeUserData();
								if (pkg.FindFile(txmt.FileDescriptor)==null) pkg.Add(txmt.FileDescriptor);
							}

							
						}
					}
				
				}				

				SimPe.PackedFiles.Wrapper.Str str = new Str();
				str.Add(new StrItem(0, 0, "SimPE Skin Override: "+skintone+" (from "+sitem.PackageCacheItem.Name+")", ""));

				str.FileDescriptor = new SimPe.Packages.PackedFileDescriptor();
				str.FileDescriptor.Type = Data.MetaData.STRING_FILE;
				str.FileDescriptor.Group = Data.MetaData.LOCAL_GROUP;
				str.FileDescriptor.LongInstance = 0;

				str.SynchronizeUserData();
				pkg.Add(str.FileDescriptor);
			} 
			finally 
			{
				//restore the Previous FileTable
				FileTable.FileIndex.RestoreLastState();
				WaitingScreen.Stop();
			}

			return pkg;
		}
	}
}
