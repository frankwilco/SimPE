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

namespace SimPe.Plugin.Tool.Action
{
	/// <summary>
	/// The ReloadFileTable Action
	/// </summary>
	public class ActionCheckFiletable : SimPe.Interfaces.IToolAction
	{
		
		#region IToolAction Member

		public virtual bool ChangeEnabledStateEventHandler(object sender, SimPe.Events.ResourceEventArgs es)
		{
			return es.Loaded;								
		}
		string GetString(SimPe.Interfaces.Files.IPackedFileDescriptor pfd)
		{
			return pfd.ExceptionString+" (o="+Helper.HexString(pfd.Offset)+", s="+Helper.HexString(pfd.Size)+")";
		}

		public void ExecuteEventHandler(object sender, SimPe.Events.ResourceEventArgs e)
		{
			if (!ChangeEnabledStateEventHandler(null, e)) return;
			
			SimPe.FileTable.FileIndex.Load();
			
			System.IO.StreamWriter sw = new System.IO.StreamWriter(new System.IO.MemoryStream());
			try 
			{
				foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in e.LoadedPackage.Package.FileIndex.Flatten()) 
				{
					SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] fiis = FileTable.FileIndex.FindFile(pfd, e.LoadedPackage.Package);

					if (fiis.Length!=1) 
					{
						sw.WriteLine(GetString(pfd)+" found "+fiis.Length.ToString()+" times.");
						foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii in fiis) 
						{
							sw.WriteLine("    "+fii.Package.FileName+": "+GetString(fii.FileDescriptor));
						}
					}
					else if (fiis[0].FileDescriptor.Offset!=pfd.Offset || fiis[0].FileDescriptor.Size!=pfd.Size) 
					{
						sw.WriteLine(GetString(pfd)+" "+" <> "+GetString(fiis[0].FileDescriptor));
					}
				}

				Report f= new Report();
				f.Execute(sw);
			}
			finally 
			{
				sw.Close();
			}
		}

		#endregion		

		
		#region IToolPlugin Member
		public override string ToString()
		{
			return "Check FileTable";
		}
		#endregion

		#region IToolExt Member
		public System.Windows.Forms.Shortcut Shortcut
		{
			get
			{
				return System.Windows.Forms.Shortcut.None;
			}
		}

		public System.Drawing.Image Icon
		{
			get
			{
				return null;
			}
		}

		#endregion
	}
}
