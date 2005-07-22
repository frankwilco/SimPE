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
using SimPe.Events;

namespace SimPe
{
	public class ToolMenuItemExt  : TD.SandBar.MenuButtonItem
	{
		/// <summary>
		/// Those delegates can be called when a Tool want's to notify the Host Application
		/// </summary>
		public delegate void ExternalToolNotify(object sender, PackageArg pk);
		IToolPlugin tool;
		

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

		/// <summary>
		/// Return null, or the stored  Tool
		/// </summary>
		public ITool Tool 
		{
			get 
			{
				if (tool is SimPe.Interfaces.ITool) return (SimPe.Interfaces.ITool)tool;
				else return null;
			}
		}

		/// <summary>
		/// Return null, or the stored ToolPlus Item
		/// </summary>
		public IToolPlus ToolPlus 
		{
			get 
			{
				if (tool is SimPe.Interfaces.IToolPlus) return (SimPe.Interfaces.IToolPlus)tool;
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

		public ToolMenuItemExt(IToolPlus tool, ExternalToolNotify chghnd) : this(tool.ToString(), tool, chghnd)
		{			
		}

		public ToolMenuItemExt(string text, IToolPlugin tool, ExternalToolNotify chghnd) 
		{
			this.tool = tool;
			this.Text = text;
			Activate += new EventHandler(LinkClicked);
			Activate += new EventHandler(ClickItem);
			chghandler = chghnd;
		}
		
		private void ClickItem(object sender, System.EventArgs e) 
		{
			if (Tool==null) return;
			try 
			{
				if (Tool.IsEnabled(pfd, package)) 
				{
					SimPe.Interfaces.Plugin.IToolResult tr = Tool.ShowDialog(ref pfd, ref package);
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

		#region Event Handler		
		SimPe.Events.ResourceEventArgs lasteventarg;

		/// <summary>
		/// Fired when a Resource was changed by a ToolPlugin and the Enabled state needs to be changed
		/// </summary>
		internal void ChangeEnabledStateEventHandler(object sender, SimPe.Events.ResourceEventArgs e) 
		{
			this.Package = AbstractToolPlus.ExtractPackage(e);
			this.FileDescriptor = AbstractToolPlus.ExtractFileDescriptor(e);

			if (Tool!=null) 
			{
				UpdateEnabledState();
			} 
			else if (ToolPlus!=null) 
			{
				lasteventarg = e;
				this.Enabled = ToolPlus.ChangeEnabledStateEventHandler(sender, e);					
			}
		}

		/// <summary>
		/// Fired when a Link is clicked
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LinkClicked(object sender, EventArgs e)
		{
			if (ToolPlus==null) return;
			if (lasteventarg.LoadedPackage!=null) lasteventarg.LoadedPackage.PauseIndexChangedEvents();
			ToolPlus.Execute(sender, lasteventarg);
			if (lasteventarg.LoadedPackage!=null) lasteventarg.LoadedPackage.RestartIndexChangedEvents();
		}
		#endregion

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

		void UpdateEnabledState()
		{
			try 
			{
				Enabled = Tool.IsEnabled(pfd, package);
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
		public static void AddMenuItem(ref SimPe.Events.ChangedResourceEvent ev, TD.SandBar.MenuItemBase.MenuItemCollection parent, ToolMenuItemExt item, string[] parts)
		{
			System.Reflection.Assembly a = typeof(LoadFileWrappersExt).Assembly;

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
					
					if (parent!=null) 
					{
						System.IO.Stream imgstr = a.GetManifestResourceStream("SimPe."+parts[i]+".png");
						if (imgstr!=null) mi.Image = System.Drawing.Image.FromStream(imgstr);
						parent.Insert(0, mi);
					}
					
				}

				parent = mi.Items;
			}

			if (item.ToolExt!=null) 
			{
				item.Shortcut = item.ToolExt.Shortcut;
				item.Image = item.ToolExt.Icon;
			}

			parent.Add(item);			
			ev += new SimPe.Events.ChangedResourceEvent(item.ChangeEnabledStateEventHandler);
			item.ChangeEnabledStateEventHandler(item, new SimPe.Events.ResourceEventArgs(null));			
		}

		/// <summary>
		/// Build a ToolBar that matches the Content of a MenuItem
		/// </summary>
		/// <param name="tb"></param>
		/// <param name="mi"></param>
		/// <param name="exclude">List of <see cref="TD.SandBar.MenuButtonItem"/> that should be excluded</param>
		public static void BuildToolBar(TD.SandBar.ToolBar tb, TD.SandBar.MenuItemBase.MenuItemCollection mi, ArrayList exclude)
		{
			ArrayList submenus = new ArrayList();
			ArrayList items = new ArrayList();

			for (int i=mi.Count-1; i>=0; i--)
			{
				if (mi[i].Items.Count>0) submenus.Add(mi[i].Items);
				else 
				{
					TD.SandBar.MenuButtonItem item = mi[i];
					if (exclude.Contains(item)) continue;
					if (item.Image==null) items.Add(item);
					else items.Insert(0, item);
				}
			}

			for (int i=0; i<items.Count; i++)
			{
				TD.SandBar.MenuButtonItem item = (TD.SandBar.MenuButtonItem)items[i];				
				TD.SandBar.ButtonItem bi = new TD.SandBar.ButtonItem();
				bi.Image = item.Image;				
				bi.Visible = (item.Image!=null);
				if (bi.Image==null) bi.Text = item.Text;
				bi.ToolTipText = item.Text.Replace("&", "");
				bi.Enabled = item.Enabled;
				bi.BuddyMenu = item;
				bi.BeginGroup = (i==0 && tb.Items.Count>0) || item.BeginGroup;

				tb.Items.Add(bi);
			}
			

			for (int i=0; i<submenus.Count; i++)
				BuildToolBar(tb, (TD.SandBar.MenuItemBase.MenuItemCollection)submenus[i], exclude);			
		}

		TD.SandBar.MenuBarItem mi;
		/// <summary>
		/// Adds the Tool Plugins to the passed menu
		/// </summary>
		/// <param name="mi">The Menu you want to add Items to</param>
		/// <param name="chghandler">A Function to call when the Package was chaged by a Tool</param>
		public static void AddMenuItems(IToolExt[] toolsp, ref SimPe.Events.ChangedResourceEvent ev, TD.SandBar.MenuBarItem mi, ToolMenuItemExt.ExternalToolNotify chghandler) 
		{			
			foreach (IToolExt tool in toolsp)
			{		
				string name = tool.ToString();
				string[] parts = name.Split("\\".ToCharArray());
				name = SimPe.Localization.GetString(parts[parts.Length-1]);
				ToolMenuItemExt item = new ToolMenuItemExt(name, tool, chghandler);

				AddMenuItem(ref ev, mi.Items, item, parts);
			}
		}
		/// <summary>
		/// Adds the Tool Plugins to the passed menu
		/// </summary>
		/// <param name="mi">The Menu you want to add Items to</param>
		/// <param name="chghandler">A Function to call when the Package was chaged by a Tool</param>
		public void AddMenuItems(ref SimPe.Events.ChangedResourceEvent ev, TD.SandBar.MenuBarItem mi, TD.SandBar.ToolBar tb, ToolMenuItemExt.ExternalToolNotify chghandler) 
		{
			this.mi = mi;
			IToolExt[] toolsp = (IToolExt[])FileTable.ToolRegistry.ToolsPlus;
			AddMenuItems(toolsp, ref ev, mi, chghandler);

			ITool[] tools = FileTable.ToolRegistry.Tools;
			
			foreach (ITool tool in tools)
			{
				string name = tool.ToString();
				string[] parts = name.Split("\\".ToCharArray());
				name = SimPe.Localization.GetString(parts[parts.Length-1]);
				ToolMenuItemExt item = new ToolMenuItemExt(name, tool, chghandler);

				AddMenuItem(ref ev, mi.Items, item, parts);
			}

			BuildToolBar(tb, mi.Items, new ArrayList());
			//EnableMenuItems(null);
		}

		/*/// <summary>
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
		}*/

		/*/// <summary>
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
		*/
		
	}
}
