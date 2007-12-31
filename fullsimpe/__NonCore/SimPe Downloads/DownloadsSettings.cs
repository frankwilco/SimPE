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
using System.Resources;
using System.Globalization;

namespace SimPe.Plugin.Downloads
{
	/// <summary>
	/// The Preferences for the Content Plugin
	/// </summary>
	public class DownloadsSettings : SimPe.GlobalizedObject, SimPe.Interfaces.ISettings
	{
		
		static ResourceManager  rm = new ResourceManager(typeof(DownloadsSettings));
		const string BASENAME = "DownloadsPlugin";
		XmlRegistryKey xrk;			
		public DownloadsSettings() : base(rm)
		{
			xrk = Helper.WindowsRegistry.PluginRegistryKey;
		}

		[System.ComponentModel.Category("Other")]
		public  bool BuildPreviewForObjects
		{
			get 
			{
				XmlRegistryKey rkf = xrk.CreateSubKey(BASENAME);
				object o = rkf.GetValue("BuildPreviewForObjects", true);
				return Convert.ToBoolean(o);
			}
			set
			{
				XmlRegistryKey rkf = xrk.CreateSubKey(BASENAME);
				rkf.SetValue("BuildPreviewForObjects", value);
			}
		}

		[System.ComponentModel.Category("Recolors")]
		public  bool BuildPreviewForRecolors
		{
			get 
			{
				XmlRegistryKey rkf = xrk.CreateSubKey(BASENAME);
				object o = rkf.GetValue("BuildPreviewForRecolors", true);
				return Convert.ToBoolean(o);
			}
			set
			{
				XmlRegistryKey rkf = xrk.CreateSubKey(BASENAME);
				rkf.SetValue("BuildPreviewForRecolors", value);

				if (value) LoadBasedataForRecolors = true;
			}
		}

		[System.ComponentModel.Category("Recolors")]
		public bool LoadBasedataForRecolors
		{
			get 
			{
				XmlRegistryKey rkf = xrk.CreateSubKey(BASENAME);
				object o = rkf.GetValue("LoadBasedataForRecolors", true);
				return Convert.ToBoolean(o);
			}
			set
			{
				XmlRegistryKey rkf = xrk.CreateSubKey(BASENAME);
				rkf.SetValue("LoadBasedataForRecolors", value);

				if (!value) BuildPreviewForRecolors = false;
			}
		}

		#region ISettings Member

		public object GetSettingsObject()
		{
			return this;
		}

		public override string ToString()
		{
			return rm.GetString("Content Plugin Preferences");
		}

		[System.ComponentModel.Browsable(false)]
		public System.Drawing.Image Icon
		{
			get
			{
				// TODO:  No Image available
				return null;
			}
		}
		#endregion
	}
}
