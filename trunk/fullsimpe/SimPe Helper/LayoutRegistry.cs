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
using System.IO;
using System.Xml;
#if MAC
#else
using Microsoft.Win32;
#endif


namespace SimPe
{
	/// <summary>
	/// Handles Layout Settings for the Application
	/// </summary>
	/// <remarks>You cannot create instance of this class, use the 
	/// <see cref="SimPe.Helper.WindowsRegistry.Layout"/> Field to access the LayoutRegistry</remarks>
	public class LayoutRegistry
	{
		#region Attributes		

		/// <summary>
		/// The Root Registry Key for this Application
		/// </summary>
		XmlRegistryKey xrk;
		#endregion

		#region Management
		XmlRegistry reg;
		/// <summary>
		/// Creates a new Instance
		/// </summary>
		/// <param name="layoutkey">Key to the Layout</param>
		internal LayoutRegistry(XmlRegistryKey layoutkey)
		{
			reg = new XmlRegistry(System.IO.Path.Combine(Helper.SimPeDataPath, "layout.xreg"), true);
			xrk = reg.CurrentUser.CreateSubKey("Software\\Ambertation\\SimPe\\Layout");						
		}	

		

		/// <summary>
		/// Returns the Registry Key you can use to store Optional Plugin Data
		/// </summary>
		public XmlRegistryKey LayoutRegistryKey
		{
			get 
			{
				return xrk.CreateSubKey("PluginLayout");
			}
		}

		/// <summary>
		/// Descturtor 
		/// </summary>
		/// <remarks>
		/// Will flsuh the XmlRegistry to the disk
		/// </remarks>
		~LayoutRegistry()
		{
			//Flush();
		}

		/// <summary>
		/// Write the Settings to the Disk
		/// </summary>
		public void Flush() 
		{
			if (reg!=null) reg.Flush();
		}
		
		#endregion

		

		/// <summary>
		/// true, if the user wantsto use the package Maintainer
		/// </summary>
		public byte SelectedTheme
		{
			get 
			{
				object o = xrk.GetValue("ThemeID", (int)1);
				return (byte)Convert.ToInt32(o);
			}
			set
			{
				xrk.SetValue("ThemeID", (int)value);
			}
		}

		/// <summary>
		/// Returns the SandBar layout Settings for the main GUI
		/// </summary>
		public string SandBarLayout 
		{
			get 
			{
				object o = xrk.GetValue("SandBar", "");
				return o.ToString();
			}
			set
			{
				xrk.SetValue("SandBar", value);
			}
		}

		/// <summary>
		/// Returns the SandDock layout Settings for the main GUI
		/// </summary>
		public string SandDockLayout 
		{
			get 
			{
				object o = xrk.GetValue("SandDock", "");
				return o.ToString();
			}
			set
			{
				xrk.SetValue("SandDock", value);
			}
		}	
		
		/// <summary>
		/// true if the taskBox should be presented expanded
		/// </summary>
		public bool DefaultActionBoxExpanded
		{
			get 
			{
				object o = xrk.GetValue("ActionDefExpanded", true);
				return Convert.ToBoolean(o);
			}
			set
			{
				xrk.SetValue("ActionDefExpanded", value);
			}
		}

		/// <summary>
		/// true if the taskBox should be presented expanded
		/// </summary>
		public bool ToolActionBoxExpanded
		{
			get 
			{
				object o = xrk.GetValue("ActionToolExpanded", false);
				return Convert.ToBoolean(o);
			}
			set
			{
				xrk.SetValue("ActionToolExpanded", value);
			}
		}

		/// <summary>
		/// true if the taskBox should be presented expanded
		/// </summary>
		public bool PluginActionBoxExpanded
		{
			get 
			{
				object o = xrk.GetValue("ActionPlugExpanded", false);
				return Convert.ToBoolean(o);
			}
			set
			{
				xrk.SetValue("ActionPlugExpanded", value);
			}
		}
	}
}
