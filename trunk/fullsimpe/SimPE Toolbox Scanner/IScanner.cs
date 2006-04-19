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
using SimPe.Interfaces.Files;
using SimPe.Plugin;


namespace SimPe.Interfaces.Plugin.Scanner
{
	/// <summary>
	/// Implements one scanner
	/// </summary>
	public interface IScanner : IScannerPluginBase
	{		
		/// <summary>
		/// Set the Delegate that should be called when a ControlClick (from an OperationControl) was executed
		/// </summary>
		/// <param name="fkt">The delegate</param>
		void SetFinishCallback(SimPe.Plugin.Scanner.AbstractScanner.UpdateList fkt);

		/// <summary>
		/// Caleed before a new Scan is stared
		/// </summary>
		void InitScan(System.Windows.Forms.ListView lv);

		/// <summary>
		/// Called if a non Cached Item was found that should be displayed
		/// </summary>
		/// <param name="si">The Object representing the ScannedFile</param>
		/// <param name="ps">The State of this File for this Scanner</param>
		/// <param name="lvi">The ListView Item that is used to display</param>
		/// <remarks>This needs to update the cache Item!</remarks>
		void ScanPackage(ScannerItem si, SimPe.Cache.PackageState ps, System.Windows.Forms.ListViewItem lvi);

		/// <summary>
		/// Called if a Cached Item was found that should be displayed
		/// </summary>
		/// <param name="si">The Object representing the ScannedFile</param>
		/// <param name="ps">The State of this File for this Scanner</param>
		/// <param name="lvi">The ListView Item that is used to display</param>
		void UpdateState(ScannerItem si, SimPe.Cache.PackageState ps, System.Windows.Forms.ListViewItem lvi);

		/// <summary>
		/// Called after the Scan was Finished completley
		/// </summary>
		void FinishScan();

		/// <summary>
		/// The uid that was assigned to the scanner
		/// </summary>
		uint Uid 
		{
			get;
		}

		/// <summary>
		/// Returns true, if this scanner should be activated by Default
		/// </summary>
		bool IsActiveByDefault
		{
			get;
		}

		/// <summary>
		/// Returns true, if this Scanner should be listed on the Top of the List
		/// </summary>
		bool OnTop 
		{
			get;
		}

		/// <summary>
		/// Returns null or a valid Control, that will be displayed on the Controls Tab
		/// </summary>
		System.Windows.Forms.Control OperationControl
		{
			get;
		}

		/// <summary>
		/// This is called, when the Selection of the ListView was changed, or a Scan was started
		/// </summary>
		/// <param name="active">true, if the Scanner was used in the last scan</param>
		void EnableControl(bool active);

		/// <summary>
		/// This is called, when the Selection of the ListView was changed, or a Scan was started
		/// </summary>
		/// <param name="item">a Scanner item (or null)</param>
		/// <param name="active">true, if the Scanner was used in the last scan</param>
		void EnableControl(ScannerItem item, bool active);

		/// <summary>
		/// This is called, when the Selection of the ListView was changed, or a Scan was started
		/// </summary>
		/// <param name="items">All selected ScannerItems</param>
		/// <param name="active">true, if the Scanner was used in the last scan</param>
		void EnableControl(ScannerItem[] items, bool active);
	}
}
