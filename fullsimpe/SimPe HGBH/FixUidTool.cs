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
using SimPe.Interfaces;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für ImportSemiTool.
	/// </summary>
	public class FixUidTool : Interfaces.ITool
	{
		
		internal FixUidTool() 
		{
		
		}

		#region ITool Member

		public bool IsEnabled(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile package)
		{			
			return true;
		}

		public Interfaces.Plugin.IToolResult ShowDialog(ref SimPe.Interfaces.Files.IPackedFileDescriptor pfd, ref SimPe.Interfaces.Files.IPackageFile package)
		{		
			System.Windows.Forms.DialogResult dr = 
				System.Windows.Forms.MessageBox.Show("Using this Tool can serioulsy mess up all of your Neighborhoods. However if some of your Neighborhoods are missing in the Neighborhood Selection of the Game, this Tool might help fixing it.\n\nMake sure you have a Backup of ALL your Neighborhoods befor starting this Tool!\n\nDo you want to start this Tool?", "Confirmation", System.Windows.Forms.MessageBoxButtons.YesNo);


			if (dr == System.Windows.Forms.DialogResult.Yes) 
			{
				WaitingScreen.Wait();
				try 
				{
                    System.Collections.Hashtable ht = Idno.FindUids(PathProvider.SimSavegameFolder, true);
					foreach (string file in ht.Keys) 
					{
						WaitingScreen.UpdateMessage(file);

						SimPe.Packages.GeneratableFile fl = SimPe.Packages.GeneratableFile.LoadFromFile(file);
						SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = fl.FindFiles(Data.MetaData.IDNO);
						foreach (SimPe.Interfaces.Files.IPackedFileDescriptor spfd in pfds) 
						{
							Idno idno = new Idno();
							idno.ProcessData(spfd, fl);
							idno.MakeUnique(ht);

							idno.SynchronizeUserData();
						}

						fl.Save();
					}
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
			return new ToolResult(false, false);
		}

		public override string ToString()
		{
			return "Neighborhood\\Fix Neighborhood Uid's";
		}

		#endregion
	}
}
