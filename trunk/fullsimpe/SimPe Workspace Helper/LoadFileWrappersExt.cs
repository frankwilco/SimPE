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
using System.Reflection;
using System.Collections;
using System.IO;
using SimPe.Interfaces;
using SimPe.Interfaces.Plugin;

namespace SimPe
{
	public class ToolMenuItemExt  : TD.SandBar.MenuButtonItem
	{
		/// <summary>
		/// Those delegates can be called when a Tool want's to notify the Host Application
		/// </summary>
		public delegate void ExternalToolNotify(object sender, PackageArg pk);
		ITool tool;
		/// <summary>
		/// Returns the stored Tool
		/// </summary>
		public ITool Tool
		{
			get {return tool;}
		}

		/// <summary>
		/// Return null, or the stored extended Tool
		/// </summary>
		public IToolExt ToolExt 
		{
			get 
			{
				//if (tool.GetType().GetInterface("SimPe.Interfaces.IToolExt", true) == typeof(SimPe.Interfaces.IToolExt)) return (SimPe.Interfaces.IToolExt)tool;
				if (tool is SimPe.Interfaces.IToolExt) return (SimPe.Interfaces.IToolExt)tool;
				else return null;
			}
		}
		Interfaces.Files.IPackedFileDescriptor pfd;
		Interfaces.Files.IPackageFile package;
		/// <summary>
		/// null or a Function to call when the Pacakge was changed by a Tool Plugin
		/// </summary>
		ExternalToolNotify chghandler;

		ExternalToolNotify ChangeHandler 
		{
			get { return chghandler; }
			set {chghandler = value; }
		}

		public ToolMenuItemExt(ITool tool, ExternalToolNotify chghnd) : this(tool.ToString(), tool, chghnd)
		{			
		}

		public ToolMenuItemExt(string text, ITool tool, ExternalToolNotify chghnd) 
		{
			this.tool = tool;
			this.Text = text;
			Activate += new EventHandler(ClickItem);
			chghandler = chghnd;
		}
		
		private void ClickItem(object sender, System.EventArgs e) 
		{
			try 
			{
				if (tool.IsEnabled(pfd, package)) 
				{
					SimPe.Interfaces.Plugin.IToolResult tr = tool.ShowDialog(ref pfd, ref package);
					WaitingScreen.Stop();
					if (tr.ChangedAny) 
					{
						PackageArg p = new PackageArg();
						p.Package = package;
						p.FileDescriptor = pfd;
						p.Result = tr;
						if (chghandler!=null) chghandler(this, p);
					}
				}
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("Unable to Start ToolPlugin.", ex);
			}
		}

		public override string ToString()
		{
			try 
			{
				return tool.ToString();
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("Unable to Load ToolPlugin.", ex);
			}

			return "Plugin Error";
		}

		public Interfaces.Files.IPackedFileDescriptor FileDescriptor
		{
			get { return pfd; }
			set { pfd = value; }
		}

		public Interfaces.Files.IPackageFile Package
		{
			get { return package; }
			set { package = value; }
		}

		public void UpdateEnabledState()
		{
			try 
			{
				Enabled = tool.IsEnabled(pfd, package);
			} 
			catch (Exception)
			{
				Enabled = false;
			}
		}
	}

	/// <summary>
	/// Class that can be used to Load external Filewrappers int the given Registry
	/// </summary>
	public class LoadFileWrappersExt : LoadFileWrappers
	{
		/// <summary>
		/// Constructor of The class
		/// </summary>
		/// <param name="registry">
		/// Registry the External Data should be added to
		/// </param>
		/// <param name="toolreg">Registry the tools should be added to</param>
		public LoadFileWrappersExt() :base(FileTable.WrapperRegistry, FileTable.ToolRegistry)
		{
		}

		/// <summary>
		/// Add one single MenuItem (and all needed Parents)
		/// </summary>
		/// <param name="item"></param>
		/// <param name="parts"></param>
		public void AddMenuItem(TD.SandBar.MenuItemBase.MenuItemCollection parent, ToolMenuItemExt item, string[] parts)
		{
			for (int i=0; i<parts.Length-1; i++) 
			{
				string name = SimPe.Localization.GetString(parts[i]);
				TD.SandBar.MenuButtonItem mi = null;
				//find an existing Menu Item
				if (parent!=null) 
				{
					foreach (TD.SandBar.MenuButtonItem oi in parent) 
					{
						if (oi.Text.ToLower().Trim()==name.ToLower().Trim()) 
						{
							mi = oi;
							break;
						}
					}
				}
				if (mi==null) 
				{
					mi = new TD.SandBar.MenuButtonItem(name);
					if (parent!=null) parent.Insert(0, mi);
					
				}

				parent = mi.Items;
			}

			if (item.ToolExt!=null) 
			{
				item.Shortcut = item.ToolExt.Shortcut;
				item.Image = item.ToolExt.Icon;
			}
			parent.Add(item);			
		}

		TD.SandBar.MenuBarItem mi;
		/// <summary>
		/// Adds the Tool Plugins to the passed menu
		/// </summary>
		/// <param name="mi">The Menu you want to add Items to</param>
		/// <param name="chghandler">A Function to call when the Package was chaged by a Tool</param>
		public void AddMenuItems(TD.SandBar.MenuBarItem mi, ToolMenuItemExt.ExternalToolNotify chghandler) 
		{
			this.mi = mi;
			ITool[] tools = FileTable.ToolRegistry.Tools;
			foreach (ITool tool in tools)
			{
				string name = tool.ToString();
				string[] parts = name.Split("\\".ToCharArray());
				name = SimPe.Localization.GetString(parts[parts.Length-1]);
				ToolMenuItemExt item = new ToolMenuItemExt(name, tool, chghandler);

				AddMenuItem(mi.Items, item, parts);
			}

			EnableMenuItems(null);
		}

		/// <summary>
		/// Used to determin the enabled State of a Tool
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void ActiveDocumentChanged(object sender, TD.SandDock.ActiveDocumentEventArgs e)
		{
			if (e==null) EnableMenuItems(null);
			else if (e.NewActiveDocument==null) EnableMenuItems(null);
			else if (e.NewActiveDocument.Tag is SimPe.Interfaces.Plugin.IFileWrapper) 
				EnableMenuItems((SimPe.Interfaces.Plugin.IFileWrapper)e.NewActiveDocument.Tag);
		}

		/// <summary>
		/// Used to determin the Enabled state of a Tool
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void ChangedPackage(LoadedPackage sender) 
		{
			EnableMenuItems(null, sender.Package);
		}

		/// <summary>
		/// Set the Enabled state of the Tool MenuItems
		/// </summary>
		/// <param name="mi"></param>
		/// <param name="wrapper"></param>
		void EnableMenuItems(SimPe.Interfaces.Plugin.IFileWrapper wrapper)
		{
			if (wrapper==null) EnableMenuItems(null, null);
			else EnableMenuItems(wrapper.FileDescriptor, wrapper.Package);
		}

		/// <summary>
		/// Set the Enabled state of the Tool MenuItems
		/// </summary>
		/// <param name="parent"></param>
		/// <param name="pfd"></param>
		/// <param name="package"></param>
		void EnableMenuItems(TD.SandBar.MenuItemBase.MenuItemCollection parent, SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile package)
		{
			foreach(TD.SandBar.MenuButtonItem item in parent) 
			{
				try 
				{
					if (item is ToolMenuItemExt) 
					{
						ToolMenuItemExt tmi = (ToolMenuItemExt)item;
						tmi.Package = package;
						tmi.FileDescriptor = pfd;
						tmi.UpdateEnabledState();
					} 
					else 
					{
						EnableMenuItems(item.Items, pfd, package);
					}
				} 
				catch (Exception) {}
			}
		}

		/// <summary>
		/// Set the Enabled state of the Tool MenuItems
		/// </summary>
		/// <param name="mi"></param>
		/// <param name="wrapper"></param>
		void EnableMenuItems(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile package)
		{
			EnableMenuItems(mi.Items, pfd, package);
		}

		
	}
}
