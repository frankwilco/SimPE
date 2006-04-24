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
	/// This is the entry point for the RemoteHandlers of the main SimPE Form
	/// </summary>
	internal class RemoteHandler
	{
		LoadedPackage lp;
		SimPe.ResourceLoader rl;
		TD.SandBar.MenuBarItem docs;
		PluginManager plugger;
		internal RemoteHandler(System.Windows.Forms.Form form, LoadedPackage lp, ResourceLoader rl, TD.SandBar.MenuBarItem docmenu) 
		{
			this.lp = lp;
			this.rl = rl;
			docs = docmenu;
			this.plugger = null;

			RemoteControl.OpenPackageFkt = new SimPe.RemoteControl.OpenPackageDelegate(OpenPackage);
			RemoteControl.OpenPackedFileFkt = new SimPe.RemoteControl.OpenPackedFileDelegate(OpenPackedFile);
			RemoteControl.OpenMemoryPackageFkt = new SimPe.RemoteControl.OpenMemPackageDelegate(OpenMemPackage);
			RemoteControl.ShowDockFkt = new SimPe.RemoteControl.ShowDockDelegate(ShowDock);

			RemoteControl.ApplicationForm = form;
		}

        internal void SetPlugger(PluginManager plugger)
        {
            this.plugger = plugger;
        }

		public bool OpenPackage(string filename)
		{
			if (!System.IO.File.Exists(filename)) return false;

			return lp.LoadFromFile(filename);
		}

		public bool OpenMemPackage(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			if (pkg==null) return false;
			if (!(pkg is SimPe.Packages.GeneratableFile)) return false;

			return lp.LoadFromPackage((SimPe.Packages.GeneratableFile)pkg);
		}

		public bool OpenPackedFile(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii) 
		{
			if (fii==null) return false;		

			try 
			{
				if (fii.Package!=null) 
				{
					if (!fii.Package.Equals(lp.Package)) 
					{
						int bprc = Helper.WindowsRegistry.BigPackageResourceCount;
						Helper.WindowsRegistry.BigPackageResourceCount = int.MaxValue;

						if (!lp.LoadFromPackage((SimPe.Packages.GeneratableFile)fii.Package)) 
						{
							Helper.WindowsRegistry.BigPackageResourceCount = bprc;
							return false;
						}
						Helper.WindowsRegistry.BigPackageResourceCount = bprc;
					}
				}
			} 
			catch (Exception ex)
			{
				Helper.ExceptionMessage(ex);
				return false;
			}

			bool res = rl.AddResource(fii, false);
			if (res && LoadedResource!=null) FireLoadEvent(fii);

			return res;
		}

		/// <summary>
		/// Fires the <see cref="LoadedResource"/> Event
		/// </summary>
		/// <param name="fii"></param>
		public void FireLoadEvent(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii)
		{
			SimPe.Events.ResourceEventArgs e = new SimPe.Events.ResourceEventArgs(lp);
			e.Items.Add(new SimPe.Events.ResourceContainer(fii));
			LoadedResource(this, e);
		}

		/// <summary>
		/// Fires when the Remote COntrol did select a File
		/// </summary>
		public event SimPe.Events.ChangedResourceEvent LoadedResource;

		/// <summary>
		/// Make a doc Visible or Hide it
		/// </summary>
		/// <param name="doc">The Doc you want to show/hide</param>
		public void ShowDock(TD.SandDock.DockControl doc, bool hide)
		{
			if (hide && (doc.IsDocked || doc.IsFloating)) doc.Close();
			if (!hide ) 
			{
				doc.Open();
				if (!(doc.IsDocked || doc.IsFloating)) 
					plugger.ChangedGuiResourceEventHandler();				
			}

			foreach (TD.SandBar.MenuButtonItem mi in docs.Items)
			{
				if (mi.Tag == doc) 				
					mi.Checked = doc.IsDocked || doc.IsFloating;				
			}
		}
	}

	
}
