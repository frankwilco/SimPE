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
			TD.SandDock.DocumentContainer dc, 
			LoadedPackage lp,
			SteepValley.Windows.Forms.ThemedControls.XPTaskBox defaultactiontaskbox,
			TD.SandBar.MenuBarItem defaultactionmenu,
			SteepValley.Windows.Forms.ThemedControls.XPTaskBox actiontaskbox, 
			TD.SandBar.ToolBar actiontoolbar)
		{
			SimPe.PackedFiles.TypeRegistry tr = new SimPe.PackedFiles.TypeRegistry();

			FileTable.ProviderRegistry = tr;
			FileTable.ToolRegistry = tr;
			FileTable.WrapperRegistry = tr;

			wloader = new LoadFileWrappersExt();

			this.LoadStaticWrappers();
			this.LoadDynamicWrappers();

			wloader.AddMenuItems(toolmenu, new ToolMenuItemExt.ExternalToolNotify(ClosedToolPluginHandler));
			dc.ActiveDocumentChanged += new TD.SandDock.ActiveDocumentEventHandler(wloader.ActiveDocumentChanged);

			lp.AfterFileLoad += new SimPe.Events.PackageFileLoadedEvent(wloader.ChangedPackage);

			
			LoadActionTools(defaultactiontaskbox, actiontoolbar, defaultactionmenu, GetDefaultActions());
			LoadActionTools(actiontaskbox, actiontoolbar, null, null);
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
		event SimPe.Events.ChangedResourceEvent ChangeEnabledStateEvent;
		
		/// <summary>
		/// Fired when a Resource was changed by a ToolPlugin and the Enabled state needs to be changed
		/// </summary>
		public void ChangeEnabledStateEventHandler(object sender, SimPe.Events.ResourceEventArgs[] e, LoadedPackage guipackage)
		{
			if (ChangeEnabledStateEvent!=null) ChangeEnabledStateEvent(sender, e, guipackage);
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
		void LoadActionTools(SteepValley.Windows.Forms.ThemedControls.XPTaskBox taskbox, TD.SandBar.ToolBar tb, TD.SandBar.MenuBarItem mi, SimPe.Interfaces.IToolAction[] tools)
		{			
			if (tools==null) tools = FileTable.ToolRegistry.Actions;

			int top = taskbox.ClientRectangle.Top + 4 + taskbox.DockPadding.Top;
			bool first = true;
			foreach (SimPe.Interfaces.IToolAction tool in tools) 
			{
				ActionToolDescriptor atd = new ActionToolDescriptor(tool);
				ChangeEnabledStateEvent += new SimPe.Events.ChangedResourceEvent(atd.ChangeEnabledStateEventHandler);				

				if (taskbox!=null) 
				{
					atd.LinkLabel.Top = top;
					atd.LinkLabel.Left = 12;
					top += atd.LinkLabel.Height;
					atd.LinkLabel.Parent = taskbox;
					atd.LinkLabel.Visible = taskbox.IsExpanded;
					atd.LinkLabel.AutoSize = true;
					//atd.LinkLabel.Width = taskbox.Width - (atd.LinkLabel.Left + 8);
					//atd.LinkLabel.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
					//atd.LinkLabel.Dock = System.Windows.Forms.DockStyle.Top;
				}

				if (mi!=null) mi.Items.Add(atd.MenuButton);

				if (tb!=null && atd.ToolBarButton!=null)
				{
					atd.ToolBarButton.BeginGroup = (first && tb.Items.Count!=0);
					tb.Items.Add(atd.ToolBarButton);
					first = false;
				}
				
			}
			taskbox.Height = top + 4;
		}
		#endregion
	}
}
