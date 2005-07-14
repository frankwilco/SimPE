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

namespace SimPe
{
	/// <summary>
	/// This class manages the initialization of Various Plugins
	/// </summary>
	public class PluginManager
	{
		LoadFileWrappersExt wloader;
		internal PluginManager(
			TD.SandBar.MenuBarItem toolmenu, 
			TD.SandBar.ToolBar tootoolbar,
			TD.SandDock.DocumentContainer dc, 
			LoadedPackage lp,
			SteepValley.Windows.Forms.ThemedControls.XPTaskBox defaultactiontaskbox,
			TD.SandBar.MenuBarItem defaultactionmenu,
			SteepValley.Windows.Forms.ThemedControls.XPTaskBox toolactiontaskbox, 
			SteepValley.Windows.Forms.ThemedControls.XPTaskBox extactiontaskbox,
			TD.SandBar.ToolBar actiontoolbar,
			TD.SandDock.DockControl docktooldc)
		{
			SimPe.PackedFiles.TypeRegistry tr = new SimPe.PackedFiles.TypeRegistry();

			FileTable.ProviderRegistry = tr;
			FileTable.ToolRegistry = tr;
			FileTable.WrapperRegistry = tr;

			wloader = new LoadFileWrappersExt();

			this.LoadStaticWrappers();
			this.LoadDynamicWrappers();

			wloader.AddMenuItems(ref ChangedGuiResourceEvent, toolmenu, tootoolbar, new ToolMenuItemExt.ExternalToolNotify(ClosedToolPluginHandler));
			//dc.ActiveDocumentChanged += new TD.SandDock.ActiveDocumentEventHandler(wloader.ActiveDocumentChanged);
			//lp.AfterFileLoad += new SimPe.Events.PackageFileLoadedEvent(wloader.ChangedPackage);

			
			LoadActionTools(defaultactiontaskbox, actiontoolbar, defaultactionmenu, GetDefaultActions());
			LoadActionTools(toolactiontaskbox, actiontoolbar, defaultactionmenu, LoadExternalTools());
			LoadActionTools(extactiontaskbox, actiontoolbar, null, null);
			
			LoadDocks(docktooldc, lp);
		}

		/// <summary>
		/// Event Wrapper
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="pk"></param>
		void ClosedToolPluginHandler(object sender, PackageArg pk)
		{
			if (ClosedToolPlugin!=null) ClosedToolPlugin(sender, pk);
		}

		/// <summary>
		/// Fired when th ePluigin Tool returns
		/// </summary>
		public event ToolMenuItemExt.ExternalToolNotify ClosedToolPlugin;

		/// <summary>
		/// Load all Static FileWrappers (theese Wrappers are allways available!)
		/// </summary>
		void LoadStaticWrappers()
		{
			FileTable.WrapperRegistry.Register(new SimPe.PackedFiles.Wrapper.Factory.SimFactory());
			FileTable.WrapperRegistry.Register(new SimPe.PackedFiles.Wrapper.Factory.ExtendedWrapperFactory());
			FileTable.WrapperRegistry.Register(new SimPe.PackedFiles.Wrapper.Factory.DefaultWrapperFactory());
			FileTable.WrapperRegistry.Register(new SimPe.PackedFiles.Wrapper.Factory.GenericWrapperFactory());
			FileTable.WrapperRegistry.Register(new SimPe.Plugin.WrapperFactory());
			FileTable.WrapperRegistry.Register(new SimPe.Plugin.RefFileFactory());
			FileTable.WrapperRegistry.Register(new SimPe.PackedFiles.Wrapper.Factory.ClstWrapperFactory());
		}

		/// <summary>
		/// Load all Wrappers found in the Plugins Folder
		/// </summary>
		void LoadDynamicWrappers()
		{			
			wloader.Scan(Helper.SimPePluginPath);
			//wloader.AddMenuItems(this.miPlugins, new EventHandler(ToolChangePacakge));
		}

		#region Action Tools		
		event SimPe.Events.ChangedResourceEvent ChangedGuiResourceEvent;
		
		/// <summary>
		/// Fired when a Resource was changed by a ToolPlugin and the Enabled state needs to be changed
		/// </summary>
		public void ChangedGuiResourceEventHandler(object sender, SimPe.Events.ResourceEventArgs e)
		{
			if (ChangedGuiResourceEvent!=null) ChangedGuiResourceEvent(sender, e);
		}

		/// <summary>
		/// Returns a List of Builtin Actions
		/// </summary>
		/// <returns></returns>
		SimPe.Interfaces.IToolAction[] GetDefaultActions()
		{
			return new SimPe.Interfaces.IToolAction[] {
														  new SimPe.Actions.Default.AddAction(),
														  new SimPe.Actions.Default.ExportAction(),
														  new SimPe.Actions.Default.ReplaceAction(),
														  new SimPe.Actions.Default.DeleteAction(),
														  new SimPe.Actions.Default.RestoreAction(),
														  new SimPe.Actions.Default.CloneAction(),
														  new SimPe.Actions.Default.CreateAction()
													  };
		}

		/// <summary>
		/// Load all available Action Tools
		/// </summary>
		void LoadActionTools(
			SteepValley.Windows.Forms.ThemedControls.XPTaskBox taskbox, 
			TD.SandBar.ToolBar tb, 
			TD.SandBar.MenuBarItem mi, 
			SimPe.Interfaces.IToolAction[] tools)
		{			
			if (tools==null) tools = FileTable.ToolRegistry.Actions;

			int top =  4 + taskbox.DockPadding.Top;
			if (taskbox.Tag!=null) top = (int)taskbox.Tag;

			bool tfirst = true;
			bool mfirst = true;
			foreach (SimPe.Interfaces.IToolAction tool in tools) 
			{
				ActionToolDescriptor atd = new ActionToolDescriptor(tool);
				ChangedGuiResourceEvent += new SimPe.Events.ChangedResourceEvent(atd.ChangeEnabledStateEventHandler);				

				if (taskbox!=null) 
				{
					atd.LinkLabel.Top = top;
					atd.LinkLabel.Left = 12;
					top += atd.LinkLabel.Height;
					atd.LinkLabel.Parent = taskbox;
					atd.LinkLabel.Visible = taskbox.IsExpanded;
					atd.LinkLabel.AutoSize = true;
				}

				if (mi!=null) 
				{
					mi.Items.Add(atd.MenuButton);
					atd.MenuButton.BeginGroup = (mfirst && mi.Items.Count!=0);
					mfirst = false;
				}

				if (tb!=null && atd.ToolBarButton!=null)
				{
					atd.ToolBarButton.BeginGroup = (tfirst && tb.Items.Count!=0);
					tb.Items.Add(atd.ToolBarButton);
					tfirst = false;
				}
				
			}
			taskbox.Height = top + 4;
			taskbox.Tag = top;
		}
		#endregion

		#region External Program Tools
		SimPe.Interfaces.IToolAction[] LoadExternalTools()
		{
   			ToolLoaderItemExt[] items = ToolLoaderExt.Items;
			SimPe.Interfaces.IToolAction[] tools = new SimPe.Interfaces.IToolAction[items.Length];
			for (int i=0; i<items.Length; i++)
				tools[i] = new SimPe.Actions.Default.StartExternalToolAction(items[i]);
			
			return tools;
		}
		#endregion

		#region dockable Tools
		void LoadDocks(TD.SandDock.DockControl dc, LoadedPackage lp)
		{
			foreach (SimPe.Interfaces.IDockableTool idt in FileTable.ToolRegistry.Docks)
			{
				TD.SandDock.DockControl dctrl = idt.GetDockableControl();
				if (dctrl!=null) 
				{
					dctrl.Manager = dc.Manager;
					dctrl.PerformDock(dc.LayoutSystem);

					ChangedGuiResourceEvent += new SimPe.Events.ChangedResourceEvent(idt.RefreshDock);
					dctrl.Tag = idt.Shortcut;
					idt.RefreshDock(this, new SimPe.Events.ResourceEventArgs(lp));
				}
			}
		}
		#endregion
	}
}
