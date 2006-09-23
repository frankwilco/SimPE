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
using System.ComponentModel;

namespace SimPe
{
	/// <summary>
	/// Zusammenfassung für PathSettings.
	/// </summary>
	public class PathSettings : SimPe.GlobalizedObject
	{
		Registry r;
		public PathSettings(Registry r)
		{
			this.r = r;
		}

		string GetPath(string userpath, string defpath)
		{
			if (userpath==null) userpath="";
			if (userpath.Trim()=="") return defpath;
			return userpath;
		}

		[Category("BasicGame"), Description("GamePath"), System.ComponentModel.Editor(typeof(SimPe.SelectSimFolderUITypeEditor), typeof(System.Drawing.Design.UITypeEditor))]
		public string GamePath
		{
			get {
				return GetPath(r.SimsPath, r.RealGamePath);
			}
			set {r.SimsPath = value;}
		}

		[Category("ExpansionPack"), System.ComponentModel.Editor(typeof(SimPe.SelectSimFolderUITypeEditor), typeof(System.Drawing.Design.UITypeEditor))]
		public string EP1Path
		{
			get 
			{
				return GetPath(r.SimsEP1Path, r.RealEP1GamePath);
			}
			set {
				r.SimsEP1Path = value;
			}
		}

		[Category("ExpansionPack"),System.ComponentModel.Editor(typeof(SimPe.SelectSimFolderUITypeEditor), typeof(System.Drawing.Design.UITypeEditor))]
		public string EP2Path
		{
			get 
			{
				return GetPath(r.SimsEP2Path, r.RealEP2GamePath);
			}
			set {r.SimsEP2Path = value;}
		}

		[Category("ExpansionPack"),System.ComponentModel.Editor(typeof(SimPe.SelectSimFolderUITypeEditor), typeof(System.Drawing.Design.UITypeEditor))]
		public string EP3Path
		{
			get 
			{
				return GetPath(r.SimsEP3Path, r.RealEP3GamePath);
			}
			set {r.SimsEP3Path = value;}
		}

		[Category("SmallExpansionPack"),System.ComponentModel.Editor(typeof(SimPe.SelectSimFolderUITypeEditor), typeof(System.Drawing.Design.UITypeEditor))]
		public string SP1Path
		{
			get 
			{
				return GetPath(r.SimsSP1Path, r.RealSP1GamePath);
			}
			set {r.SimsSP1Path = value;}
		}

        [Category("SmallExpansionPack"), System.ComponentModel.Editor(typeof(SimPe.SelectSimFolderUITypeEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public string SP2Path
        {
            get
            {
                return GetPath(r.SimsSP2Path, r.RealSP2GamePath);
            }
            set { r.SimsSP2Path = value; }
        }

		[Category("BasicGame"),System.ComponentModel.Editor(typeof(SimPe.SelectSimFolderUITypeEditor), typeof(System.Drawing.Design.UITypeEditor))]
		public string SaveGamePath
		{
			get 
			{
				return GetPath(r.SimSavegameFolder, r.RealSavegamePath);
			}
			set {r.SimSavegameFolder = value;}
		}
	}
}
